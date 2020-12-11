using System;
using System.Collections.Generic;
using System.Text;
using VehicleProject.Data1.Model;
using VehicleProject.Persistence.Infastructure;
using VehicleProject.Service.Interface;

namespace VehicleProject.Service.Implementation
{
    public class VehicleInfoService : IVehicleInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehicleInfoService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        
   
        VehicleInfo IVehicleInfoService.GetById(int id)
        {
            return this._unitOfWork.VehicleInfoRepository.GetById(id);
        }

      

        public bool DeleteVehicleInfo(int VehicleInfoId)
        {

            VehicleInfo vehicleInfo = this._unitOfWork.VehicleInfoRepository.GetById(VehicleInfoId);
            if (vehicleInfo != null)
            {
                this._unitOfWork.VehicleInfoRepository.Remove(vehicleInfo);
                this._unitOfWork.Save();

                return true;
            }
            return false;
        }

        public IEnumerable<VehicleInfo> GetAllVehicleInfo()
        {
            return this._unitOfWork.VehicleInfoRepository.GetAll();
        }

        public VehicleInfo AddVehicleInfo(VehicleInfo vehicleInfo)
        {

            this._unitOfWork.VehicleInfoRepository.Add(vehicleInfo);
            this._unitOfWork.Save();

            return vehicleInfo;
        }

        public VehicleInfo UpdateVehicleInfo(VehicleInfo vehicleInfo)
        {

            this._unitOfWork.VehicleInfoRepository.Update(vehicleInfo);
            this._unitOfWork.Save();

            return vehicleInfo;
        }
    }
}
