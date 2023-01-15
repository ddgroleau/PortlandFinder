using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Infrastructure.Repositories
{
    [TestFixture]
    public class LocationRespositoryTests
    {
        private MockDbContext _mockDb = new MockDbContext();
        private ILocationRepository _locationRepository;

        [OneTimeSetUp]
        public void BeforeAll()
        {
            _locationRepository = new LocationRepository(_mockDb);
        }

        [Test]
        public async Task GetLocations_ReturnsAllLocations()
        {
            Assert.IsTrue((await _locationRepository.GetLocations()).Any());
        }
    }
}
