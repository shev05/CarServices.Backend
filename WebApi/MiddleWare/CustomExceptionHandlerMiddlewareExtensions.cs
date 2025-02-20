namespace CarServices.WebApi.MiddleWare
{
    public static class CustomExceptionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this
            IApplicationBuilder buider)
        {
            return buider.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}
