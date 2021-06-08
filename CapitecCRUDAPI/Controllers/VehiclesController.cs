using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitecCRUDAPI.Models;
using CapitecCRUDAPI.VihicleData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitecCRUDAPI.Controllers
{
    
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private IVehicleData _vehicleData;

        public VehiclesController(IVehicleData vehicleData)
        {
            _vehicleData = vehicleData;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetVehicle(int id)
        {
            var vehicle = _vehicleData.GetVehicle(id);

            if(vehicle != null)
            {
                return Ok(vehicle);
            }
            return NotFound($"Vehicle with id: {id} was not found - please enter a valid id");
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetVehicles()
        {
            return Ok(_vehicleData.GetVehicles());
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddVehicle(Vehicle vehicle)
        {
            _vehicleData.AddVehicle(vehicle);

            var created = Created(HttpContext.Request.Scheme + "://" +
                          HttpContext.Request.Host + HttpContext.Request.Path +
                          "/" + vehicle.ID, vehicle);
            return created;
            
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult UpdateVehicle(int id, Vehicle updatingVehicle)
        {
            var vehicle = _vehicleData.GetVehicle(id);

            if (vehicle != null)
            {
                updatingVehicle.ID = vehicle.ID;
                _vehicleData.Updatehicle(updatingVehicle);
                
            }
            return Ok(updatingVehicle);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteVehicle(int id)
        {
            var vehicle = _vehicleData.GetVehicle(id);

            if (vehicle != null)
            {
                _vehicleData.DeleteVehicle(vehicle);
                return Ok($"Vehicle with id: {id} was deleted");
            }
            return NotFound($"Vehicle with id: {id} was not found - please enter a valid id");
        }


    }
}