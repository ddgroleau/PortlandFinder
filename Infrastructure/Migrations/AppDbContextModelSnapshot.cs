﻿// <auto-generated />
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Domain.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectionsUri")
                        .HasColumnType("TEXT");

                    b.Property<double>("Distance")
                        .HasColumnType("REAL");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.683100000000003,
                            Longitude = -70.289929999999998,
                            Name = "Back Bay Superette",
                            Notes = "Ask at Checkout",
                            Phone = "2077475754",
                            State = "ME",
                            StreetAddress = "1037 Forest Ave",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 2,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.657060000000001,
                            Longitude = -70.248819999999995,
                            Name = "Casco Bay Lines",
                            Notes = "Ask at Ferry Terminal ticket counter",
                            Phone = "2077747871",
                            State = "ME",
                            StreetAddress = "56 Commercial Street",
                            ZipCode = "04101"
                        },
                        new
                        {
                            Id = 3,
                            City = "Cliff Island",
                            Distance = 0.0,
                            Latitude = 43.694400000000002,
                            Longitude = -70.109089999999995,
                            Name = "Cliff Island Store & Cafe",
                            Notes = "Open June 24- Sept 5 \nAsk at Checkout",
                            Phone = "2077662312",
                            State = "ME",
                            StreetAddress = "11 Wharf Rd",
                            ZipCode = "04019"
                        },
                        new
                        {
                            Id = 4,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.686199999999999,
                            Longitude = -70.292810000000003,
                            Name = "Cumberland Farms",
                            Notes = "Ask at Checkout",
                            Phone = "2077979927",
                            State = "ME",
                            StreetAddress = "1136 Forest Ave",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 5,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.651409999999998,
                            Longitude = -70.268630000000002,
                            Name = "Cumberland Farms",
                            Notes = "Ask at Checkout",
                            Phone = "2078749528",
                            State = "ME",
                            StreetAddress = "49 Pine St",
                            ZipCode = "04102"
                        },
                        new
                        {
                            Id = 6,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.686583800000001,
                            Longitude = -70.268517500000002,
                            Name = "Cumberland Farms",
                            Notes = "Ask at Checkout",
                            Phone = "2077808032",
                            State = "ME",
                            StreetAddress = "801 Washington Ave",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 7,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.668931299999997,
                            Longitude = -70.301337000000004,
                            Name = "Cumberland Farms",
                            Notes = "Ask at Checkout",
                            Phone = "2077737792",
                            State = "ME",
                            StreetAddress = "512 Woodfords St",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 8,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.666674399999998,
                            Longitude = -70.276269999999997,
                            Name = "CVS",
                            Notes = "Ask at Checkout",
                            Phone = "2077721928",
                            State = "ME",
                            StreetAddress = "449 Forest Ave.",
                            ZipCode = "04101"
                        },
                        new
                        {
                            Id = 9,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.658794499999999,
                            Longitude = -70.297687499999995,
                            Name = "CVS",
                            Notes = "Ask at Checkout",
                            Phone = "2077743636",
                            State = "ME",
                            StreetAddress = "1406 Congress St",
                            ZipCode = "04102"
                        },
                        new
                        {
                            Id = 10,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.703988899999999,
                            Longitude = -70.288760100000005,
                            Name = "CVS",
                            Notes = "Checkout & Drive Thru",
                            Phone = "2077973393",
                            State = "ME",
                            StreetAddress = "111 Auburn St",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 11,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.6558846,
                            Longitude = -70.260373000000001,
                            Name = "CVS",
                            Notes = "Ask at Checkout",
                            Phone = "2077744525",
                            State = "ME",
                            StreetAddress = "510 Congress St",
                            ZipCode = "04102"
                        },
                        new
                        {
                            Id = 12,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.687002300000003,
                            Longitude = -70.259357499999993,
                            Name = "Eldridge Lumber & Hardware",
                            Notes = "Ask at Checkout",
                            Phone = "2077703004",
                            State = "ME",
                            StreetAddress = "145 Presumpscot St",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 13,
                            City = "Falmouth",
                            Distance = 0.0,
                            Latitude = 43.734770099999999,
                            Longitude = -70.296048799999994,
                            Name = "Hannaford",
                            Notes = "Customer Service/ Checkout/ To-Go",
                            Phone = "2078780050",
                            State = "ME",
                            StreetAddress = "65 Gray Rd",
                            ZipCode = "04105"
                        },
                        new
                        {
                            Id = 14,
                            City = "Westbrook",
                            Distance = 0.0,
                            Latitude = 43.675995800000003,
                            Longitude = -70.355133899999998,
                            Name = "Hannaford",
                            Notes = "Customer Service/ Checkout/ To-Go",
                            Phone = "2078544631",
                            State = "ME",
                            StreetAddress = "7 Hannaford Dr",
                            ZipCode = "04092"
                        },
                        new
                        {
                            Id = 15,
                            City = "South Portland",
                            Distance = 0.0,
                            Latitude = 43.637839700000001,
                            Longitude = -70.2503399,
                            Name = "Hannaford",
                            Notes = "Customer Service/ Checkout/ To-Go",
                            Phone = "2077997359",
                            State = "ME",
                            StreetAddress = "50 Cottage Rd",
                            ZipCode = "04106"
                        },
                        new
                        {
                            Id = 16,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.663645099999997,
                            Longitude = -70.268522300000001,
                            Name = "Hannaford",
                            Notes = "Customer Service/ Checkout/ To-Go",
                            Phone = "2077915965",
                            State = "ME",
                            StreetAddress = "295 Forest Ave",
                            ZipCode = "04101"
                        },
                        new
                        {
                            Id = 17,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.701788200000003,
                            Longitude = -70.319492299999993,
                            Name = "Hannaford",
                            Notes = "Customer Service/ Checkout/ To-Go",
                            Phone = "2078780191",
                            State = "ME",
                            StreetAddress = "787 Riverside St",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 18,
                            City = "South Portland",
                            Distance = 0.0,
                            Latitude = 43.633817399999998,
                            Longitude = -70.329078499999994,
                            Name = "Hannaford",
                            Notes = "Customer Service/ Checkout/ To-Go",
                            Phone = "2077612729",
                            State = "ME",
                            StreetAddress = "415 Philbrook Ave",
                            ZipCode = "04106"
                        },
                        new
                        {
                            Id = 19,
                            City = "Peaks Island",
                            Distance = 0.0,
                            Latitude = 43.656719500000001,
                            Longitude = -70.197916699999993,
                            Name = "Hannigan's Market",
                            Notes = "Ask at Checkout",
                            Phone = "2077662351",
                            State = "ME",
                            StreetAddress = "75 Island Ave",
                            ZipCode = "04108"
                        },
                        new
                        {
                            Id = 20,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.652640599999998,
                            Longitude = -70.280329800000004,
                            Name = "Maine Hardware",
                            Notes = "Ask at Checkout",
                            Phone = "2077735604",
                            State = "ME",
                            StreetAddress = "274 Saint John St",
                            ZipCode = "04102"
                        },
                        new
                        {
                            Id = 21,
                            City = "Westbrook",
                            Distance = 0.0,
                            Latitude = 43.680179099999997,
                            Longitude = -70.330726400000003,
                            Name = "Market Basket",
                            Notes = "Customer Service/ Checkout",
                            Phone = "2074642100",
                            State = "ME",
                            StreetAddress = "207 Larrabee Rd",
                            ZipCode = "04092"
                        },
                        new
                        {
                            Id = 22,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.696506100000001,
                            Longitude = -70.306728800000002,
                            Name = "Moran's Market",
                            Notes = "Ask at Checkout",
                            Phone = "2077976674",
                            State = "ME",
                            StreetAddress = "1576 Forest Ave",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 23,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.661100900000001,
                            Longitude = -70.252392400000005,
                            Name = "Portland food co-op",
                            Notes = "Ask at Checkout",
                            Phone = "2078051599",
                            State = "ME",
                            StreetAddress = "290 Congress St",
                            ZipCode = "04101"
                        },
                        new
                        {
                            Id = 24,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.651562400000003,
                            Longitude = -70.267805100000004,
                            Name = "Rosemont Market",
                            Notes = "Ask at Checkout",
                            Phone = "2076994181",
                            State = "ME",
                            StreetAddress = "40 Pine St",
                            ZipCode = "04102"
                        },
                        new
                        {
                            Id = 25,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.666695199999999,
                            Longitude = -70.246613999999994,
                            Name = "Rosemont Market",
                            Notes = "Ask at Checkout",
                            Phone = "2077737888",
                            State = "ME",
                            StreetAddress = "88 Congress St",
                            ZipCode = "04101"
                        },
                        new
                        {
                            Id = 26,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.668681900000003,
                            Longitude = -70.302214699999993,
                            Name = "Rosemont Market",
                            Notes = "Ask at Checkout",
                            Phone = "2077748129",
                            State = "ME",
                            StreetAddress = "580 Brighton Ave",
                            ZipCode = "04102"
                        },
                        new
                        {
                            Id = 27,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.652340899999999,
                            Longitude = -70.280264599999995,
                            Name = "Save-A-Lot",
                            Notes = "Ask at Checkout",
                            Phone = "2077720622",
                            State = "ME",
                            StreetAddress = "268 St John St",
                            ZipCode = "04102"
                        },
                        new
                        {
                            Id = 28,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.703631999999999,
                            Longitude = -70.288659999999993,
                            Name = "Shaw's",
                            Notes = "Ask at Checkout/Instacart",
                            Phone = "2077974304",
                            State = "ME",
                            StreetAddress = "91 Auburn St",
                            ZipCode = "04103"
                        },
                        new
                        {
                            Id = 29,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.658065399999998,
                            Longitude = -70.296376899999998,
                            Name = "Shaw's",
                            Notes = "Ask at Checkout/Instacart",
                            Phone = "2077747661",
                            State = "ME",
                            StreetAddress = "1364 Congress St",
                            ZipCode = "04102"
                        },
                        new
                        {
                            Id = 30,
                            City = "South Portland",
                            Distance = 0.0,
                            Latitude = 43.636472499999996,
                            Longitude = -70.255871099999993,
                            Name = "Shaw's",
                            Notes = "Ask at Checkout/Instacart",
                            Phone = "2077998149",
                            State = "ME",
                            StreetAddress = "180 Waterman Drive",
                            ZipCode = "04106"
                        },
                        new
                        {
                            Id = 31,
                            City = "Westbrook",
                            Distance = 0.0,
                            Latitude = 43.679414199999997,
                            Longitude = -70.330899200000005,
                            Name = "Shaw's",
                            Notes = "Ask at Checkout/Instacart",
                            Phone = "2078579229",
                            State = "ME",
                            StreetAddress = "31 Main St",
                            ZipCode = "04092"
                        },
                        new
                        {
                            Id = 32,
                            City = "Falmouth",
                            Distance = 0.0,
                            Latitude = 43.7243438,
                            Longitude = -70.2298337,
                            Name = "Shaw's",
                            Notes = "Ask at Checkout/Instacart",
                            Phone = "2077816581",
                            State = "ME",
                            StreetAddress = "251 US RT 1",
                            ZipCode = "04105"
                        },
                        new
                        {
                            Id = 33,
                            City = "Scarborough",
                            Distance = 0.0,
                            Latitude = 43.620249100000002,
                            Longitude = -70.350367000000006,
                            Name = "Shaw's",
                            Notes = "Ask at Checkout/Instacart",
                            Phone = "2078832443",
                            State = "ME",
                            StreetAddress = "417 Payne Rd",
                            ZipCode = "04074"
                        },
                        new
                        {
                            Id = 34,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.663312300000001,
                            Longitude = -70.258410100000006,
                            Name = "Whole Foods",
                            Notes = "Ask at Checkout/Curbside/ Amazon",
                            Phone = "2077747711",
                            State = "ME",
                            StreetAddress = "2 Somerset St",
                            ZipCode = "04101"
                        },
                        new
                        {
                            Id = 35,
                            City = "Portland",
                            Distance = 0.0,
                            Latitude = 43.661100900000001,
                            Longitude = -70.252392400000005,
                            Name = "Walgreens",
                            Notes = "Ask at Checkout",
                            Phone = "2077740344",
                            State = "ME",
                            StreetAddress = "290 Congress St",
                            ZipCode = "04101"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
