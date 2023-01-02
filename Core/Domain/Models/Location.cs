using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Location
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? StreetAddress { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? ZipCode { get; set; }

        public string? Phone { get; set; }

        public string? Notes { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
        public double Distance { get; set; }
        public string? DirectionsUri { get; set; }

    }
}
