using System;
using System.Collections.Generic;
using System.Text;
using VehicleProject.Data1.Model;

namespace VehicleProject.Service.Interface
{
    
        public interface IVehicleInfoService
        {
            IEnumerable<VehicleInfo> GetAllVehicleInfo();
            VehicleInfo GetById(int id);
           
            VehicleInfo AddVehicleInfo(VehicleInfo vehicleInfo);
            VehicleInfo UpdateVehicleInfo(VehicleInfo vehicleInfo);
            bool DeleteVehicleInfo(int VehicleInfoId);


        }
    
}
