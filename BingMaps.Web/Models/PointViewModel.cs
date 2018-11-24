using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BingMaps.Web.Models
{
    public class PointViewModel
    {
        public string EntityId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string AddressLine { get; set; }
        public string Locality { get; set; }
        public string AdminDistrict { get; set; }
        public string AdminDistrict2 { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegion { get; set; }
        public string Phone { get; set; }
        public string EntityTypeId { get; set; }
    }
}