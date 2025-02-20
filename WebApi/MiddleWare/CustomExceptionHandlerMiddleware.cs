﻿using CarServices.Application.Common.Exceptions;
using System.Net;
using System.Reflection.Metadata;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using FluentValidation;

namespace CarServices.WebApi.MiddleWare
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomExceptionHandlerMiddleware(RequestDelegate next) =>
            _next = next;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var code = HttpStatusCode.InternalServerError;
            var result = string.Empty;
            switch(ex)
            {
                case ValidationException validationException:
                    code = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(validationException.Errors);
                    break;
                case NotFoundException:
                    code = HttpStatusCode.NotFound;
                    break;
            }
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            if(result == string.Empty) 
            {
                result = JsonSerializer.Serialize(new { error = ex.Message });
            }
            return context.Response.WriteAsync(result);

        }

    }
}
