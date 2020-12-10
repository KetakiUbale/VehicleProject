﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleProject.Data.Model;

namespace VehicleProject.Data
{

   public class VehicleContext:DbContext
    {

        public DbSet<Vehicle> Vehicles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=K-S-K\\SQLEXPRESS01;Initial Catalog=Vehicle;Integrated Security = true";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
