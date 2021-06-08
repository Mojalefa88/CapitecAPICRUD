
using System.Collections.Generic;
using CapitecCRUDAPI.Models;
using System;
using System.Linq;

namespace CapitecCRUDAPI.VihicleData 
{
    public class MockVehicleData : IVehicleData
    {
        private List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle()
            {
                ID = 1,
                Year = 2019,
                Make = "VW",
                Model = "Polo",
                Color = "Black",
                Mileage = 27000,
                Type = "Car"
            },
            new Vehicle()
            {
                ID = 2,
                Year = 2015,
                Make = "BMW",
                Model = "R1250R",
                Color = "White",
                Mileage = 126000,
                Type = "Bike"
            }
        };
        public Vehicle AddVehicle(Vehicle vehicle)
        {
            vehicle.ID = vehicles.Count + 1;
            vehicles.Add(vehicle);
            return vehicle;
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }

        public Vehicle GetVehicle(int Id)
        {
            return vehicles.SingleOrDefault(x => x.ID == Id);
        }

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }

        public Vehicle Updatehicle(Vehicle vehicle)
        {
            var vehicleExist = GetVehicle(vehicle.ID);

            vehicleExist.Year = vehicle.Year;
            vehicleExist.Make = vehicle.Make;
            vehicleExist.Model = vehicle.Model;
            vehicleExist.Color = vehicle.Color;
            vehicleExist.Mileage = vehicle.Mileage;

            return vehicleExist;
        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;*/