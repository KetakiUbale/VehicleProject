﻿using Microsoft.EntityFrameworkCore;
using VehicleProject.Data;

namespace VehicleProject.Data
{

    public class VehicleContext:DbContext
    {

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=K-S-K\\SQLEXPRESS01;Initial Catalog=Vehicle;Integrated Security = true";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
