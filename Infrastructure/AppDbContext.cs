using System.Collections;
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

        public DbSet<Location>? Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().ToTable("locations");
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

            modelBuilder.Entity<Location>().HasData(SeedLocationData());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string? host = Environment.GetEnvironmentVariable("PG_HOST");
            string? port = Environment.GetEnvironmentVariable("PG_PORT");
            string? user = Environment.GetEnvironmentVariable("PG_USER");
            string? password = Environment.GetEnvironmentVariable("PG_PASSWORD");
            string? db = Environment.GetEnvironmentVariable("PG_DATABASE");
  
            options.UseNpgsql($"Host={host};Port={port};Username={user};Password={password};Database={db};");
        }

        protected List<Location> SeedLocationData()
        {
            return new List<Location> 
            {
                new Location 
                {
                    Id = 1,
                    Name = "Back Bay Superette",
                    StreetAddress = "1037 Forest Ave",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2077475754",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6831,
                    Longitude = -70.28993
                },
                new Location
                {
                    Id = 2,
                    Name = "Casco Bay Lines",
                    StreetAddress = "56 Commercial Street",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04101",
                    Phone = "2077747871",
                    Notes = "Ask at Ferry Terminal ticket counter",
                    Latitude = 43.65706,
                    Longitude = -70.24882
                },
                new Location
                {
                    Id = 3,
                    Name = "Cliff Island Store & Cafe",
                    StreetAddress = "11 Wharf Rd",
                    City = "Cliff Island",
                    State = "ME",
                    ZipCode = "04019",
                    Phone = "2077662312",
                    Notes = "Open June 24- Sept 5 - Ask at Checkout",
                    Latitude = 43.6944,
                    Longitude = -70.10909
                },
                new Location
                {
                    Id = 4,
                    Name = "Cumberland Farms",
                    StreetAddress = "1136 Forest Ave",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2077979927",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6862,
                    Longitude = -70.29281
                },
                new Location
                {
                    Id = 5,
                    Name = "Cumberland Farms",
                    StreetAddress = "49 Pine St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04102",
                    Phone = "2078749528",
                    Notes = "Ask at Checkout",
                    Latitude = 43.65141,
                    Longitude = -70.26863
                },
                new Location
                {
                    Id = 6,
                    Name = "Cumberland Farms",
                    StreetAddress = "801 Washington Ave",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2077808032",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6865838,
                    Longitude = -70.2685175
                },
                new Location
                {
                    Id = 7,
                    Name = "Cumberland Farms",
                    StreetAddress = "512 Woodfords St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2077737792",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6689313,
                    Longitude = -70.301337
                },
                new Location
                {
                    Id = 8,
                    Name = "CVS",
                    StreetAddress = "449 Forest Ave.",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04101",
                    Phone = "2077721928",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6666744,
                    Longitude = -70.27627
                },
                new Location
                {
                    Id = 9,
                    Name = "CVS",
                    StreetAddress = "1406 Congress St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04102",
                    Phone = "2077743636",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6587945,
                    Longitude = -70.2976875
                },
                new Location
                {
                    Id = 10,
                    Name = "CVS",
                    StreetAddress = "111 Auburn St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2077973393",
                    Notes = "Checkout & Drive Thru",
                    Latitude = 43.7039889,
                    Longitude = -70.2887601
                },
                new Location
                {
                    Id = 11,
                    Name = "CVS",
                    StreetAddress = "510 Congress St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04102",
                    Phone = "2077744525",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6558846,
                    Longitude = -70.260373
                },
                new Location
                {
                    Id = 12,
                    Name = "Eldridge Lumber & Hardware",
                    StreetAddress = "145 Presumpscot St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2077703004",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6870023,
                    Longitude = -70.2593575
                },
                new Location
                {
                    Id = 13,
                    Name = "Hannaford",
                    StreetAddress = "65 Gray Rd",
                    City = "Falmouth",
                    State = "ME",
                    ZipCode = "04105",
                    Phone = "2078780050",
                    Notes = "Customer Service / Checkout / To-Go",
                    Latitude = 43.7347701,
                    Longitude = -70.2960488
                },
                new Location
                {
                    Id = 14,
                    Name = "Hannaford",
                    StreetAddress = "7 Hannaford Dr",
                    City = "Westbrook",
                    State = "ME",
                    ZipCode = "04092",
                    Phone = "2078544631",
                    Notes = "Customer Service / Checkout / To-Go",
                    Latitude = 43.6759958,
                    Longitude = -70.3551339
                },
                new Location
                {
                    Id = 15,
                    Name = "Hannaford",
                    StreetAddress = "50 Cottage Rd",
                    City = "South Portland",
                    State = "ME",
                    ZipCode = "04106",
                    Phone = "2077997359",
                    Notes = "Customer Service / Checkout / To-Go",
                    Latitude = 43.6378397,
                    Longitude = -70.2503399
                },
                new Location
                {
                    Id = 16,
                    Name = "Hannaford",
                    StreetAddress = "295 Forest Ave",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04101",
                    Phone = "2077915965",
                    Notes = "Customer Service / Checkout / To-Go",
                    Latitude = 43.6636451,
                    Longitude = -70.2685223
                },
                new Location
                {
                    Id = 17,
                    Name = "Hannaford",
                    StreetAddress = "787 Riverside St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2078780191",
                    Notes = "Customer Service / Checkout / To-Go",
                    Latitude = 43.7017882,
                    Longitude = -70.3194923
                },
                new Location
                {
                    Id = 18,
                    Name = "Hannaford",
                    StreetAddress = "415 Philbrook Ave",
                    City = "South Portland",
                    State = "ME",
                    ZipCode = "04106",
                    Phone = "2077612729",
                    Notes = "Customer Service / Checkout / To-Go",
                    Latitude = 43.6338174,
                    Longitude = -70.3290785
                },
                new Location
                {
                    Id = 19,
                    Name = "Hannigan's Market",
                    StreetAddress = "75 Island Ave",
                    City = "Peaks Island",
                    State = "ME",
                    ZipCode = "04108",
                    Phone = "2077662351",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6567195,
                    Longitude = -70.1979167
                },
                new Location
                {
                    Id = 20,
                    Name = "Maine Hardware",
                    StreetAddress = "274 Saint John St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04102",
                    Phone = "2077735604",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6526406,
                    Longitude = -70.2803298
                },
                new Location
                {
                    Id = 21,
                    Name = "Market Basket",
                    StreetAddress = "207 Larrabee Rd",
                    City = "Westbrook",
                    State = "ME",
                    ZipCode = "04092",
                    Phone = "2074642100",
                    Notes = "Customer Service /  Checkout",
                    Latitude = 43.6801791,
                    Longitude = -70.3307264
                    },
                new Location
                {
                    Id = 22,
                    Name = "Moran's Market",
                    StreetAddress = "1576 Forest Ave",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2077976674",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6965061,
                    Longitude = -70.3067288
                    },
                new Location
                {
                    Id = 23,
                    Name = "Portland food co-op",
                    StreetAddress = "290 Congress St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04101",
                    Phone = "2078051599",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6611009,
                    Longitude = -70.2523924
                    },
                new Location
                {
                    Id = 24,
                    Name = "Rosemont Market",
                    StreetAddress = "40 Pine St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04102",
                    Phone = "2076994181",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6515624,
                    Longitude = -70.2678051
                    },
                new Location
                {
                    Id = 25,
                    Name = "Rosemont Market",
                    StreetAddress = "88 Congress St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04101",
                    Phone = "2077737888",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6666952,
                    Longitude = -70.246614
                    },
                new Location
                {
                    Id = 26,
                    Name = "Rosemont Market",
                    StreetAddress = "580 Brighton Ave",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04102",
                    Phone = "2077748129",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6686819,
                    Longitude = -70.3022147
                    },
                new Location
                {
                    Id = 27,
                    Name = "Save-A-Lot",
                    StreetAddress = "268 St John St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04102",
                    Phone = "2077720622",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6523409,
                    Longitude = -70.2802646
                    },
                new Location
                {
                    Id = 28,
                    Name = "Shaw's",
                    StreetAddress = "91 Auburn St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04103",
                    Phone = "2077974304",
                    Notes = "Ask at Checkout / Instacart",
                    Latitude = 43.703632,
                    Longitude = -70.28866
                    },
                new Location
                {
                    Id = 29,
                    Name = "Shaw's",
                    StreetAddress = "1364 Congress St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04102",
                    Phone = "2077747661",
                    Notes = "Ask at Checkout / Instacart",
                    Latitude = 43.6580654,
                    Longitude = -70.2963769
                    },
                new Location
                {
                    Id = 30,
                    Name = "Shaw's",
                    StreetAddress = "180 Waterman Drive",
                    City = "South Portland",
                    State = "ME",
                    ZipCode = "04106",
                    Phone = "2077998149",
                    Notes = "Ask at Checkout / Instacart",
                    Latitude = 43.636472499999996,
                    Longitude = -70.2558711
                    },
                new Location
                {
                    Id = 31,
                    Name = "Shaw's",
                    StreetAddress = "31 Main St",
                    City = "Westbrook",
                    State = "ME",
                    ZipCode = "04092",
                    Phone = "2078579229",
                    Notes = "Ask at Checkout / Instacart",
                    Latitude = 43.6794142,
                    Longitude = -70.3308992
                    },
                new Location
                {
                    Id = 32,
                    Name = "Shaw's",
                    StreetAddress = "251 US RT 1",
                    City = "Falmouth",
                    State = "ME",
                    ZipCode = "04105",
                    Phone = "2077816581",
                    Notes = "Ask at Checkout / Instacart",
                    Latitude = 43.7243438,
                    Longitude = -70.2298337
                    },
                new Location
                {
                    Id = 33,
                    Name = "Shaw's",
                    StreetAddress = "417 Payne Rd",
                    City = "Scarborough",
                    State = "ME",
                    ZipCode = "04074",
                    Phone = "2078832443",
                    Notes = "Ask at Checkout / Instacart",
                    Latitude = 43.6202491,
                    Longitude = -70.350367
                    },
                new Location
                {
                    Id = 34,
                    Name = "Whole Foods",
                    StreetAddress = "2 Somerset St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04101",
                    Phone = "2077747711",
                    Notes = "Ask at Checkout / Curbside /  Amazon",
                    Latitude = 43.6633123,
                    Longitude = -70.2584101
                    },
                new Location
                {
                    Id = 35,
                    Name = "Walgreens",
                    StreetAddress = "290 Congress St",
                    City = "Portland",
                    State = "ME",
                    ZipCode = "04101",
                    Phone = "2077740344",
                    Notes = "Ask at Checkout",
                    Latitude = 43.6611009,
                    Longitude = -70.2523924
                }
            };
        }
    }
}
