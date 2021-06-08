using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitecCRUDAPI.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string Type { get; set; }
    }
}
