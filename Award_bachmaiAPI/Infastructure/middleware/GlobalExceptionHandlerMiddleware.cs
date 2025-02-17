using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infastructure.middleware
{
    public class GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
    {
        private readonly RequestDelegate _next = next;
        private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger = logger;

        public async Task InvokeAsync(HttpContext context) // Use 'context' consistently
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred while processing the request.");
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                var errorResponse = new ErrorDetails
                {
                    StatusCode = context.Response.StatusCode,
                    Title = "Internal Server Error",
                    Detail = ex.Message,
                    ErrorCode = "500"
                };


                await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse)); // Correct this line
            }
        }
    }
}