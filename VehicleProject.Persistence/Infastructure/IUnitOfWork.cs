using System;
using System.Collections.Generic;
using System.Text;
using VehicleProject.Data1.Model;

namespace VehicleProject.Persistence
{
    public interface IUnitOfWork:IDisposable
    {
        Repository<User> UserRepository { get; }
        Repository<Vehicle> VehicleRepository { get; }
        Repository<VehicleInfo>VehicleInfoRepository { get; }
      
        int Save();
    }
}
