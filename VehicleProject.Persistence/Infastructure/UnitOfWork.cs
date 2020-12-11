
using VehicleProject.Data1;
using VehicleProject.Data1.Model;
using VehicleProject.Persistence;


namespace VehicleProject.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VehicleContext _context;
        public Repository<User> UserRepository { get; }
        public Repository<Vehicle> VehicleRepository { get; }
        public Repository<VehicleInfo> VehicleInfoRepository { get; }



        public UnitOfWork(VehicleContext context)
        {
            this._context = context;
            this.UserRepository = new Repository<User>(this._context);
            this.VehicleRepository = new Repository<Vehicle>(this._context);
            this.VehicleInfoRepository = new Repository<VehicleInfo>(this._context);
        }

        public int Save()
        {
            return this._context.SaveChanges();
        }
        public void Dispose()
        {
            this._context.Dispose();
        }
    }

       
}
