using System.Collections.Generic;
using VehicleProject.Data1.Model;
using VehicleProject.Persistence;
using VehicleProject.Service.Interface;

namespace VehicleProject.Service.Implementation
{
    public class VehicleService:IVehicleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehicleService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            this._unitOfWork.VehicleRepository.Add(vehicle);
            this._unitOfWork.Save();

            return vehicle;
        }

        public bool DeleteVehicle(int VehicleId)
        {

            Vehicle vehicle = this._unitOfWork.VehicleRepository.GetById(VehicleId);
            if (vehicle != null)
            {
                this._unitOfWork.VehicleRepository.Remove(vehicle);
                this._unitOfWork.Save();

                return true;
            }
            return false;
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return this._unitOfWork.VehicleRepository.GetAll();
        }

        public Vehicle GetById(int id)
        {
            return this._unitOfWork.VehicleRepository.GetById(id);
        }

        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            this._unitOfWork.VehicleRepository.Update(vehicle);
            this._unitOfWork.Save();

            return vehicle;
        }
    }
}
