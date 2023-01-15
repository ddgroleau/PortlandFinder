using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AppDbContext _context;

        public LocationRepository(AppDbContext context)
        {
            _context = context;
            _context.Database.Migrate();
        }

        public async Task<List<Location>> GetLocations() => await _context.Locations.ToListAsync();

    }
}
