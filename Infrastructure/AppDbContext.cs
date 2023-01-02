using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() 
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasKey(e => e.Id);
            modelBuilder.Entity<Location>().Property(e => e.Name).HasMaxLength(90).IsRequired();
            modelBuilder.Entity<Location>().Property(e => e.StreetAddress).HasMaxLength(90).IsRequired();
            modelBuilder.Entity<Location>().Property(e => e.City).HasMaxLength(90).IsRequired();
            modelBuilder.Entity<Location>().Property(e => e.State).HasMaxLength(2).IsRequired();
            modelBuilder.Entity<Location>().Property(e => e.ZipCode).HasMaxLength(5).IsRequired();
            modelBuilder.Entity<Location>().Property(e => e.Phone).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Location>().Property(e => e.Notes).HasMaxLength(200).IsRequired();
            modelBuilder.Entity<Location>().Property(e => e.Latitude).IsRequired();
            modelBuilder.Entity<Location>().Property(e => e.Longitude).IsRequired();

            using StreamReader reader = new(@"bag-locations.json");
            string locationJson = reader.ReadToEnd();
            List<Location>? locations = JsonSerializer.Deserialize<List<Location>>(locationJson);

            if (locations != null && locations.Any())
                modelBuilder.Entity<Location>().HasData(locations);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"DataSource=app.db");

    }
}
