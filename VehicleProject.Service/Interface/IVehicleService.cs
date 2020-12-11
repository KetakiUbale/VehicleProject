using System;
using System.Collections.Generic;
using System.Text;
using VehicleProject.Data1.Model;

namespace VehicleProject.Service.Interface
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetAllVehicle();
        Vehicle GetById(int id);

        Vehicle AddVehicle(Vehicle vehicle);
        Vehicle UpdateVehicle(Vehicle vehicle);
        bool DeleteVehicle(int VehicleId);


    }

}
