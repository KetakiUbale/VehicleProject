using System;
using System.Collections.Generic;
using System.Text;
using VehicleProject.Data1.Model;

namespace VehicleProject.Service.Interface
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetById(int id);
        User GetByEmail(string email);
        User AddUser(User user);
        User UpdateUser(User user);
        bool DeleteUser(int userId);


    }
}
