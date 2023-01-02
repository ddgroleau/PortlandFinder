using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/locations")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations()
        {
            List<Location> locations = await _locationService.GetLocations();
            return Ok(locations);
        }

        [HttpGet("radius/{radius}")]
        public async Task<IActionResult> GetLocationsInRadius(double latitude, double longitude, int radius)
        {
            List<Location> locations = await _locationService.GetLocationsInRadius(latitude, longitude, radius);
            return Ok(locations);
        }
       

    }
}
