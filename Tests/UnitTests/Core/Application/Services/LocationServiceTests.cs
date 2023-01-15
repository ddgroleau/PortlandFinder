using Application.Services;
using Infrastructure.Repositories;
using NSubstitute;
using Domain.Models;
using NSubstitute.ExceptionExtensions;
using Microsoft.Extensions.Logging;

namespace UnitTests.Core.Application.Services
{
    [TestFixture]
    public class LocationServiceTests
    {
        private ILocationRepository _locationRepository;
        private ILocationService _locationService;
        private ILogger<LocationService> _logger;
        private List<Location> _mockLocations;

        [OneTimeSetUp] 
        public void BeforeAll() 
        {
            _locationRepository = Substitute.For<ILocationRepository>();
            _logger = Substitute.For<ILogger<LocationService>>();
            _locationService = new LocationService(_locationRepository, _logger);
            _mockLocations = new List<Location>
            {
                new Location { Id = 1, City = "Portland", Latitude = 43.6831, Longitude = -70.2899, Name = "Back Bay Superette", State = "ME", StreetAddress = "1037 Forest Ave",  ZipCode = "04103" },
                new Location { Id = 2, City = "Portland", Latitude = 43.6571, Longitude = -70.2488, Name = "Casco Bay Lines", State =  "ME", StreetAddress = "56 Commercial Street",  ZipCode = "04101" },
                new Location { Id = 3, City = "Cliff Island", Latitude = 43.6944, Longitude = -70.1091, Name = "Cliff Island Store & Cafe", State =  "ME", StreetAddress = "11 Wharf Rd",  ZipCode = "04019" },
                new Location { Id = 4, City = "Portland",  Latitude = 43.6862, Longitude = -70.2928,  Name = "Cumberland Farms", State = "ME", StreetAddress = "1136 Forest Ave",  ZipCode = "04103" },
                new Location { Id = 5, City = "Portland", Latitude = 43.6514, Longitude = -70.2686, Name = "Cumberland Farms", State =  "ME", StreetAddress = "49 Pine St", ZipCode = "04102" }
            };
        }

        [SetUp]
        public void BeforeEach()
        {
            _locationRepository.GetLocations().Returns(Task.FromResult(_mockLocations));
        }

        [Test]
        public async Task GetLocationsInRadius_WithValidCoordinatesAndRadius_ReturnsCorrectLocationsWithDistances() 
        {
            double lat = 43.6591;
            double lon = -70.2568;
            int radius = 10;

            List<Location> actual = await _locationService.GetLocationsInRadius(lat, lon, radius);

            Assert.That(actual.Any());
            Assert.That(actual.Count.Equals(5));
            Assert.That(actual[0].DirectionsUri, Is.EqualTo($"https://www.google.com/maps/dir/{lat},{lon}/{actual[0].Latitude},{actual[0].Longitude}"));
            Assert.That(actual[0].Distance.Equals(0.42));
            Assert.That(actual[1].Distance.Equals(0.79));
            Assert.That(actual[2].Distance.Equals(2.34));
            Assert.That(actual[3].Distance.Equals(2.6));
            Assert.That(actual[4].Distance.Equals(7.77));
        }


        [TestCase(0,0)]
        [TestCase(1,2)]
        [TestCase(3,4)]
        public async Task GetLocationsInRadius_WithValidCoordinatesAndRadius_ReturnsCorrectNumberOfLocationsInRadius(int radius, int expectedCount)
        {
            double lat = 43.6591;
            double lon = -70.2568;

            List<Location> actual = await _locationService.GetLocationsInRadius(lat, lon, radius);

            Assert.That(actual.Count.Equals(expectedCount));
        }

        [TestCase(0,0,2)]
        [TestCase(91,180,10)]
        [TestCase(-90,192,3)]
        [TestCase(43.6591, -70.2568, -3)]
        public async Task GetLocationsInRadius_WithInvalidCoordinatesAndRadius_ReturnsEmptyArray(double lat, double lon, int radius) 
        {
            List<Location> actual = await _locationService.GetLocationsInRadius(lat, lon, radius);

            Assert.IsFalse(actual.Any());
        }

        [Test]
        public async Task GetLocationsInRadius_WithRepositoryError_ReturnsEmptyArray()
        {
            _locationRepository.GetLocations().ThrowsAsync(new Exception("Mock Exceptions"));
            double lat = 43.6591;
            double lon = -70.2568;
            int radius = 10;

            List<Location> actual = await _locationService.GetLocationsInRadius(lat, lon, radius);

            Assert.IsFalse(actual.Any());
        }
    }
}