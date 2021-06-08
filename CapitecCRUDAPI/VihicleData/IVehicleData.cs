using CapitecCRUDAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitecCRUDAPI.VihicleData
{
    public interface IVehicleData
    {
        Vehicle GetVehicle(int Id);
        List<Vehicle> GetVehicles();
        Vehicle AddVehicle(Vehicle vehicle);
        Vehicle Updatehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
    }
}
