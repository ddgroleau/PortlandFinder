using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/locations")]
[ApiController]
public class LocationsController : ControllerBase
{
    private readonly ILocationService _locationService;
    private readonly ILogger<LocationsController> _logger;

    public LocationsController(ILocationService locationService, ILogger<LocationsController> logger)
    {
        _locationService = locationService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetLocations()
    {
        try
        {
            List<Location> locations = await _locationService.GetLocations();

            if (!locations.Any()) return NotFound();

            return Ok(locations);
        }
        catch (Exception e)
        {
            _logger.LogError("Failed to fetch locations.", e);
            return StatusCode(StatusCodes.Status409Conflict);
        }
    }

    [HttpGet("radius/{radius}")]
    public async Task<IActionResult> GetLocationsInRadius(double latitude, double longitude, int radius)
    {
        try
        {
            List<Location> locations = await _locationService.GetLocationsInRadius(latitude, longitude, radius);

            if (!locations.Any()) return NotFound();

            return Ok(locations);
        }
        catch (Exception e)
        {
            _logger.LogError("Failed to fetch locations.", e);
            return BadRequest();
        }
    }
}
