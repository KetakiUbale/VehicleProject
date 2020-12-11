﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleProject.Data
{
  public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int pincode { get; set; }
    }
}
