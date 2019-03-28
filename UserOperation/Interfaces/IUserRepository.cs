using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserOperation.Models;

namespace UserOperation.Interfaces
{
    public interface IUserRepository
    {
        void CreateUsers();
        void CreateNewUsers(User newUser);
        void DeleteUsers(int id);
        List<User> GetUsers();
        void SetUsers( User a);
        User GetUserById(int UserId);
    }
}
