using Domain.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Persitance.DbContext
{
    public class WebAPIContext(DbContextOptions<WebAPIContext> options) : Microsoft.EntityFrameworkCore.DbContext(options)
    {
        public DbSet<Auth> Auths { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer("WebAPIContext");

        }

    }
}
