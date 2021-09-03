using Inventory.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.Authentication
{
    public interface IJwtAuth
    {
        string Authentication(User user);

    }
}
