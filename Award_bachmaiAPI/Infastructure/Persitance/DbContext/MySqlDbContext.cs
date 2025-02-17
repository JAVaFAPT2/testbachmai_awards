using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.models;

namespace Infastructure.Persitance.DbContext
{
    public class MySqlDbContext(DbContextOptions<MySqlDbContext> options) : Microsoft.EntityFrameworkCore.DbContext(options)
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration if needed
        }
    }
}
