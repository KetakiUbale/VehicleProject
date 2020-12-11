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
    public class VehicleInfoController : ControllerBase
    {

        private readonly IVehicleInfoService _vehicleinfoService;
        public VehicleInfoController(IVehicleInfoService vehicleinfoService)
        {
            this._vehicleinfoService = vehicleinfoService;
        }


        [HttpGet("getallvehicleinfo")]
        public IActionResult getallvehicleinfo()
        {

            return Ok(this._vehicleinfoService.GetAllVehicleInfo());
        }


        


        [HttpPost("addvehicleinfo")]
        public IActionResult AddVehicleInfo(VehicleInfo vehicleInfo)
        {
            return Ok(this._vehicleinfoService.AddVehicleInfo(vehicleInfo));
        }


        [HttpPut("updatevehicleinfo")]
        public IActionResult UpdateVehicleInfo(VehicleInfo vehicleInfo)
        {
            return Ok(this._vehicleinfoService.UpdateVehicleInfo(vehicleInfo));
        }

        [HttpDelete("deletevehicleinfo/{vehicleinfoId}")]
        public IActionResult DeleteVehicleInfo(int vehicleinfoid)
        {
            return Ok(this._vehicleinfoService.DeleteVehicleInfo(vehicleinfoid));
        }

    }
}
}
