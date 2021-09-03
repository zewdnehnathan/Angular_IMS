using Inventory.Domain.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.API.Authentication
{
    public class Auth : IJwtAuth
    {

        private readonly string _key;
        private readonly SymmetricSecurityKey _signingKey;
        
        public Auth(string key)
        {
            _key = key;
            _signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
            

        }

        public string Authentication(User user)
        {
            if (user == null) return null;
           
                var credentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
                var header = new JwtHeader(credentials);
                DateTime expiry = DateTime.UtcNow.AddMinutes(60);
                int expiryTimeinSec = (int)(expiry - new DateTime(1970, 1, 1)).TotalSeconds;
                var payload = new JwtPayload
            {
                {"sub",user.Username },
                {"Name",user.Password },
                 {"exp",expiryTimeinSec }
            };
                var securityToken = new JwtSecurityToken(header, payload);
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenString = tokenHandler.WriteToken(securityToken);

                return tokenString;
            
        }
    }
}
