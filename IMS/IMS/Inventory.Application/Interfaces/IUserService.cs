using Inventory.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces
{
    public interface IUserService
    {
        public User AuthenticateUser(string username, string password);

    }
}
