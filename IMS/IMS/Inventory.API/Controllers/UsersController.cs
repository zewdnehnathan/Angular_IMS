using Inventory.API.Authentication;
using Inventory.Application.Interfaces;
using Inventory.Domain.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtAuth _jwtAuth;

        public UsersController(IUserService userService, IJwtAuth jwtAuth) 
        {
            _userService = userService;
            _jwtAuth = jwtAuth;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(User user) 
        {
            var member = _userService.AuthenticateUser(user.Username, user.Password);
            return member == null ? Unauthorized() : Ok(_jwtAuth.Authentication(user));
            
        }

    }
}
