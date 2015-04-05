using System;
using System.Collections.Generic;
using System.Linq;
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
                 ClientId   = @"implicitclient",
                 ClientName = @"Web Application",
                 Enabled    = true,
                 RequireConsent = true,
                 AllowRememberConsent = true,
                 RedirectUris = new List<string>{"https://localhost:44301/"},
                 PostLogoutRedirectUris = new List<string>{"https://localhost:44301/"},
                 ScopeRestrictions = new List<string>
                        {
                            Constants.StandardScopes.OpenId,
                            Constants.StandardScopes.Profile,
                            Constants.StandardScopes.Email
                        },
                AccessTokenType = AccessTokenType.Jwt,
                AccessTokenLifetime = 5000

                }

            };
        } 

    }
}