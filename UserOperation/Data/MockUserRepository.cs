using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserOperation.Interfaces;
using UserOperation.Models;

namespace UserOperation.Data
{
    public class MockUserRepository : IUserRepository
    {

        List<User> _users;

        public void CreateUsers()
        {
            _users = new List<User>
                {
                new User { UserId= 1, UserEmail = "test01@selise.ch", UserName = "test01@selise.ch" },
                new User { UserId= 2, UserEmail = "test02@selise.ch", UserName = "test02@selise.ch" },
                new User { UserId= 3, UserEmail = "test03@selise.ch", UserName = "test03@selise.ch" },
                };

        }
        public void CreateNewUsers(User newUser)
        {
            _users.Add(new User { UserId = newUser.UserId, UserEmail = newUser.UserEmail, UserName = newUser.UserName });
                
        }

        public void DeleteUsers(int id)
        {
             _users.Remove(_users.Where(s => s.UserId == id).FirstOrDefault());

                      /*
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].UserId == id)
                {
                    _users.Remove(_users[i]);

                }
            }*/
        }

        public List<User> GetUsers()
        {
            return _users;
        }


        public User GetUserById(int UserId)
        {
            throw new NotImplementedException();
        }

        public void SetUsers(User std)
        {
            User result = _users.Where(s => s.UserId == std.UserId).FirstOrDefault();
            result.UserName= std.UserName;
            result.UserEmail = std.UserEmail;


            /*for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].UserId == std.UserId)
                {
                    _users[i].UserName = std.UserName;
                    _users[i].UserEmail = std.UserEmail;

                }
            }*/
        }
    }
}
