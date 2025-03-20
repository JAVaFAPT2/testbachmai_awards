using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;
using Infastructure.Persitance.DbContext;

namespace Infastructure.Persistence.DbContext
{
    public class WebAPIContextFactory : IDesignTimeDbContextFactory<WebAPIContext>
    {
        public WebAPIContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebAPIContext>();

            // Correctly using SetBasePath method
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionString = configuration.GetConnectionString("WebAPIContext");
            optionsBuilder.UseSqlServer(connectionString);

            return new WebAPIContext(optionsBuilder.Options);
        }
    }
}