using Api.Controllers;
using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace UnitTests.Api.Controllers;

[TestFixture]
public class LocationsControllerTests
{
    private LocationsController _locationsController;
    private ILogger<LocationsController> _logger;
    private ILocationService _locationService;

    [SetUp]
    public void BeforeEach()
    {
        _logger = Substitute.For<ILogger<LocationsController>>();
        _locationService = Substitute.For<ILocationService>();
        _locationsController = new LocationsController(_locationService, _logger);
    }
    
    [Test]
    public async Task GetLocations_WithServiceProvidingLocations_Returns200()
    {
        _locationService.GetLocations().ReturnsForAnyArgs(Task.FromResult(new List<Location>() { new Location() }));

        IActionResult response = await _locationsController.GetLocations();
        
        Assert.IsAssignableFrom<OkObjectResult>(response);
    }
    
    [Test]
    public async Task GetLocations_WithNoLocationsFound_Returns404()
    {
        List<Location>? nullLocations = null;
        _locationService.GetLocations().ReturnsForAnyArgs(Task.FromResult(nullLocations));

        IActionResult response = await _locationsController.GetLocations();
        
        Assert.IsAssignableFrom<NotFoundResult>(response);
    }
    
    [Test]
    public async Task GetLocations_WithServiceException_Returns409()
    {
        _locationService.GetLocations().Throws(new ArgumentNullException());

        IActionResult response = await _locationsController.GetLocations();
        
        Assert.IsAssignableFrom<StatusCodeResult>(response);
        Assert.That(((StatusCodeResult)response).StatusCode.Equals(StatusCodes.Status409Conflict));
    }
    
    [Test]
    public async Task GetLocationsInRadius_WithServiceProvidingLocations_Returns200()
    {
        _locationService.GetLocationsInRadius(Arg.Any<double>(),Arg.Any<double>(),Arg.Any<int>())
                        .ReturnsForAnyArgs(Task.FromResult(new List<Location>() { new Location() }));

        IActionResult response = await _locationsController.GetLocationsInRadius(90,180,1);
        
        Assert.IsAssignableFrom<OkObjectResult>(response);
    }
    
    [Test]
    public async Task GetLocationsInRadius_WithNoLocationsFound_Returns404()
    {
        _locationService.GetLocationsInRadius(Arg.Any<double>(),Arg.Any<double>(),Arg.Any<int>())
            .ReturnsForAnyArgs(Task.FromResult(new List<Location>()));

        IActionResult response = await _locationsController.GetLocationsInRadius(90,180,1);
        
        Assert.IsAssignableFrom<NotFoundResult>(response);
    }
    
    [Test]
    public async Task GetLocationsInRadius_WithServiceException_Returns400()
    {
        _locationService.GetLocationsInRadius(Arg.Any<double>(),Arg.Any<double>(),Arg.Any<int>()).Throws(new ArgumentException("Invalid radius."));

        IActionResult response = await _locationsController.GetLocationsInRadius(90,180,0);
        
        Assert.IsAssignableFrom<BadRequestResult>(response);
    }
}