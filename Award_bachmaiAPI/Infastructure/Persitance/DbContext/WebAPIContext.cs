using Domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infastructure.Persitance.DbContext
{
    public class WebAPIContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public WebAPIContext(DbContextOptions<WebAPIContext> options) : base(options) { }

        public DbSet<Auth> Auths { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("WebAPIContext");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
