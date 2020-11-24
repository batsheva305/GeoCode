using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace GeoCode.Models
{
    public class Address
    {
        public string Id { get; set; }
        public string AddressString { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int NumberOfHits { get; set; }
    }
}
