using Microsoft.EntityFrameworkCore;
using VehicleProject.Data1.Model;

namespace VehicleProject.Data1
{
    public class VehicleContext:DbContext

    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleInfo> VehicleInfo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=K-S-K\\SQLEXPRESS01;Initial Catalog=Vehicle;Integrated Security = true";
            optionsBuilder.UseSqlServer(conn);
        }

    }
}
