using Domain.Models;
using Infrastructure;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Infrastructure
{
    public class MockDbContext : AppDbContext
    {
        public MockDbContext()
        {
            Database.OpenConnection();
            Database.EnsureCreated();
        }

        public MockDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.OpenConnection();
            Database.EnsureCreated();
        }
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

            List<Location> mockLocations = new List<Location>
            {
                new Location { Id = 1, City = "Portland", Latitude = 43.6831, Longitude = -70.2899, Name = "Back Bay Superette", State = "ME", StreetAddress = "1037 Forest Ave",  ZipCode = "04103", Notes = "None", Phone = "5555555555" },
                new Location { Id = 2, City = "Portland", Latitude = 43.6571, Longitude = -70.2488, Name = "Casco Bay Lines", State =  "ME", StreetAddress = "56 Commercial Street",  ZipCode = "04101", Notes = "None",  Phone = "5555555555" },
                new Location { Id = 3, City = "Cliff Island", Latitude = 43.6944, Longitude = -70.1091, Name = "Cliff Island Store & Cafe", State =  "ME", StreetAddress = "11 Wharf Rd",  ZipCode = "04019", Notes = "None",  Phone = "5555555555" },
                new Location { Id = 4, City = "Portland",  Latitude = 43.6862, Longitude = -70.2928,  Name = "Cumberland Farms", State = "ME", StreetAddress = "1136 Forest Ave",  ZipCode = "04103", Notes = "None", Phone = "5555555555" },
                new Location { Id = 5, City = "Portland", Latitude = 43.6514, Longitude = -70.2686, Name = "Cumberland Farms", State =  "ME", StreetAddress = "49 Pine St", ZipCode = "04102", Notes = "None", Phone = "5555555555" }
            };

            modelBuilder.Entity<Location>().HasData(mockLocations);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=:memory:");
        }
    }
}
