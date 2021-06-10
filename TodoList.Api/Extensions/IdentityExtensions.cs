using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace TodoList.Api.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetUserId(this IPrincipal user)
        {
            if (user == null)
                return string.Empty;

            var identity = (ClaimsIdentity)user.Identity;
            IEnumerable<Claim> claims = identity.Claims;
            return claims.FirstOrDefault(s => s.Type == "UserId")?.Value;
        }
    }
}
