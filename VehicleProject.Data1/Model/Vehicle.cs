using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleProject.Data1.Model
{
   public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public User User { get; set; }
        public VehicleInfo VehicleInfo { get; set; }
   
    }
}
