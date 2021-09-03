using Inventory.Application.Interfaces;
using Inventory.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Features
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;
        public UserService() 
        {
            _users = new List<User>();
            _users.AddRange
                (
                    new List<User>()
                    {
                        new User
                        {
                           Username = "admin",
                           Password = "admin"
                        },
                        new User
                        {
                           Username = "Test",
                           Password = "Test"
                        }
                        
                    }
                );

        }

        public User AuthenticateUser(string username, string password)
        {
            return _users.Where(x => x.Username.ToLower().Equals(username) && x.Password.Equals(password))?.FirstOrDefault() ?? null;
        }
    }
}
