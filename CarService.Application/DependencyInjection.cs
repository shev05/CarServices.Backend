﻿using System.Reflection;
using CarServices.Application.Common.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CarServices.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services
                .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
            services
                .AddValidatorsFromAssemblies(new[] {Assembly.GetExecutingAssembly()});
            services
                .AddTransient(typeof(IPipelineBehavior<,>), 
                typeof(ValidatorBehavior<,>));
            return services;
        }
    }
}
