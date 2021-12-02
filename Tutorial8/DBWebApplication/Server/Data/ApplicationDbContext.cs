using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBWebApplication.Shared;
using Microsoft.EntityFrameworkCore;

namespace DBWebApplication.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
