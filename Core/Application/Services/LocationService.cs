using Domain.Models;
using Infrastructure.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ILogger<LocationService> _logger;

        public LocationService(ILocationRepository locationRepository, ILogger<LocationService> logger)
        {
            _locationRepository = locationRepository;
            _logger = logger;
        }

        public async Task<List<Location>> GetLocations()
        {
            return await _locationRepository.GetLocations();
        }

        public async Task<List<Location>> GetLocationsInRadius(double originLat, double originLon, int radius)
        {
            try
            {
                const string DIRECTIONS_BASE_URI = "https://www.google.com/maps/dir";

                List<Location> allLocations = await _locationRepository.GetLocations();

                foreach (Location location in allLocations)
                {
                    double distance = GetDistanceBetweenCoordinates(originLat, originLon, location.Latitude, location.Longitude);
                    location.DirectionsUri = $"{DIRECTIONS_BASE_URI}/{originLat},{originLon}/{location.Latitude},{location.Longitude}";
                    location.Distance = Math.Round(distance, 2);
                }

                return allLocations.Where(location => location.Distance <= radius).OrderBy(location => location.Distance).ToList();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error thrown while geolocating coordinates.");
                return new List<Location>();
            }
        }

        private double GetDistanceBetweenCoordinates(double originLat, double originLon, double destLat, double destLon)
        {
            // Haversine Formula Implementation
            const double EARTH_RADIUS_MILES = 3958.8;

            double latDifference = (Math.PI / 180) * (destLat - originLat);
            double lonDifference = (Math.PI / 180) * (destLon - originLon);

            double originLatRadians = (Math.PI / 180) * (originLat);
            double destLatRadians = (Math.PI / 180) * (destLat);

            double squaredChordLength = Math.Pow(Math.Sin(latDifference / 2), 2) +
            Math.Pow(Math.Sin(lonDifference / 2), 2) *
            Math.Cos(originLatRadians) * Math.Cos(destLatRadians);
            
            double angularDistanceRadians = 2 * Math.Asin(Math.Sqrt(squaredChordLength));
            
            return EARTH_RADIUS_MILES * angularDistanceRadians;
        }
    }
}
