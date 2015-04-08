using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Collections.Generic;
using Thinktecture.IdentityServer.Core;
using Thinktecture.IdentityServer.Core.Models;

namespace IdentityServerLearning.Identity.Configuration
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {

            return new List<Client>
            {
                
                new Client()
                {
                 ClientName = "ConsoleApp",
                    ClientId = "Console", 
                 Enabled    = true,
                    Flow = Flows.ClientCredentials,
                 
                 
                 
                AccessTokenType = AccessTokenType.Reference,
                ClientSecrets = new List<ClientSecret>
                    {
                    new ClientSecret("mysecret".Sha256())
                    }
                
                
                }
            };
        } 

    }
}