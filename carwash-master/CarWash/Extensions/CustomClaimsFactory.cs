using CarWash.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarWash.Extensions
{
    public class CustomClaimsFactory : UserClaimsPrincipalFactory<User>
    {
        public CustomClaimsFactory(UserManager<User> userManager, IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
        {
        }
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
        {
            var role = await UserManager.GetRolesAsync(user);
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("username", user.UserName));
            identity.AddClaim(new Claim("name", user.Name));
            identity.AddClaim(new Claim(ClaimTypes.Role, role.FirstOrDefault()));



            return identity;
        }
    }
}
