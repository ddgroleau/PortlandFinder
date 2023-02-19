using Api.Controllers;
using Application.Services;
using Domain.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace IntegrationTests
{
    [TestFixture]
    public class LocationsControllerTests
    {
        private LocationsController _locationsController;
        private ILocationService _locationService;
        private ILogger<LocationsController> _logger;
        private ILocationRepository _locationRepository;
        
        [OneTimeSetUp]
        public void BeforeAll()
        {
            _locationRepository = Substitute.For<ILocationRepository>();
            _logger = Substitute.For<ILogger<LocationsController>>();
            _locationService = new LocationService(_locationRepository);
            _locationsController = new LocationsController(_locationService, _logger);
            
            List<Location> mockLocations = new List<Location>
            {
                new Location { Id = 1, City = "Portland", Latitude = 43.6831, Longitude = -70.2899, Name = "Back Bay Superette", State = "ME", StreetAddress = "1037 Forest Ave",  ZipCode = "04103", Notes = "None", Phone = "5555555555" },
                new Location { Id = 2, City = "Portland", Latitude = 43.6571, Longitude = -70.2488, Name = "Casco Bay Lines", State =  "ME", StreetAddress = "56 Commercial Street",  ZipCode = "04101", Notes = "None",  Phone = "5555555555" },
                new Location { Id = 3, City = "Cliff Island", Latitude = 43.6944, Longitude = -70.1091, Name = "Cliff Island Store & Cafe", State =  "ME", StreetAddress = "11 Wharf Rd",  ZipCode = "04019", Notes = "None",  Phone = "5555555555" },
                new Location { Id = 4, City = "Portland",  Latitude = 43.6862, Longitude = -70.2928,  Name = "Cumberland Farms", State = "ME", StreetAddress = "1136 Forest Ave",  ZipCode = "04103", Notes = "None", Phone = "5555555555" },
                new Location { Id = 5, City = "Portland", Latitude = 43.6514, Longitude = -70.2686, Name = "Cumberland Farms", State =  "ME", StreetAddress = "49 Pine St", ZipCode = "04102", Notes = "None", Phone = "5555555555" }
            };

            _locationRepository.GetLocations().ReturnsForAnyArgs(Task.FromResult(mockLocations));
        }

        [Test]
        public async Task GetLocations_WithServiceProvidingLocations_Returns200()
            => Assert.IsAssignableFrom<OkObjectResult>(await _locationsController.GetLocations());
        

        [Test]
        public async Task GetLocationsInRadius_WithServiceProvidingLocations_Returns200()
            => Assert.IsAssignableFrom<OkObjectResult>(await _locationsController.GetLocationsInRadius(43.6831180,-70.2899,50));

        
        [Test]
        public async Task GetLocationsInRadius_WithNoLocationsFound_Returns404()
            => Assert.IsAssignableFrom<NotFoundResult>(await _locationsController.GetLocationsInRadius(90,180,1));

        
        [Test]
        public async Task GetLocationsInRadius_WithServiceException_Returns400()
            => Assert.IsAssignableFrom<BadRequestResult>(await _locationsController.GetLocationsInRadius(90,180,0));

    }
}