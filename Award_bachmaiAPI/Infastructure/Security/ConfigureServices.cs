using Microsoft.Extensions.DependencyInjection;
// Add this using directive

// Add this using directive

namespace Infastructure.Security;

public static class ConfigureServices
{
    public static void AddCustomCors(this IServiceCollection services, string angularClientUrl)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAngularClient", builder =>
            {
                builder.WithOrigins(angularClientUrl) // Allow the Angular client URL
                    .AllowAnyHeader() // Allow any header
                    .AllowAnyMethod() // Allow any method (GET, POST, etc.)
                    .AllowCredentials(); // Allow credentials if needed
            });
        });
    }
}