using System.Collections.Generic;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace IdentityServerLearning.Identity.Configuration
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "BShair",
                    Password = "Password123!",
                    Subject = "1",
                    Claims = new List<Claim>
                    {
                        new Claim(Constants.ClaimTypes.GivenName, "Shair"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Super :)"),
                        new Claim(Constants.ClaimTypes.NickName,"MBS")
                    }
                }

            };
        }
    }
}