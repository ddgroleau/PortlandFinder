using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ILocationService
    {
        Task<List<Location>> GetLocations();
        Task<List<Location>> GetLocationsInRadius(double latitude, double longitude, int radius);
    }
}
