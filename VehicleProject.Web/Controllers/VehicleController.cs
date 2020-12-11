using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleProject.Data1.Model;
using VehicleProject.Service.Interface;

namespace VehicleProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        private readonly IVehicleService _vehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            this._vehicleService = vehicleService;
        }


        [HttpGet("getallvehicle")]
        public IActionResult getallusers()
        {

            return Ok(this._vehicleService.GetAllVehicle());
        }


       


        [HttpPost("addvehicle")]
        public IActionResult AddUser(Vehicle vehicle)
        {
            return Ok(this._vehicleService.AddVehicle(vehicle));
        }


        [HttpPut("updateuser")]
        public IActionResult UpdateUser(Vehicle vehicle)
        {
            return Ok(this._vehicleService.UpdateVehicle(vehicle));
        }

        [HttpDelete("deletevehicle/{vehicleId}")]
        public IActionResult DeleteUser(int vehicleid)
        {
            return Ok(this._vehicleService.DeleteVehicle(vehicleid));
        }

    }
}
}
