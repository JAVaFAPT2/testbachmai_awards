using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors.Infrastructure; // Add this using directive
using Microsoft.AspNetCore.Builder; // Add this using directive

namespace Infastructure.Security
{
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
}
