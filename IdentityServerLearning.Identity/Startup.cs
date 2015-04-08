using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServerLearning.Identity.Configuration;
using Owin;
using Thinktecture.IdentityServer.Core.Configuration;

namespace IdentityServerLearning.Identity
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            app.Map("/myHome",
                coreApp => coreApp.UseIdentityServer(new IdentityServerOptions
                {
                 //   SiteName = "MBS Identity Server",
                    //SigningCertificate = Cert.Load(),
                     Factory =  InMemoryFactory.Create(
                users: Users.Get(),
                clients: Clients.Get(),
                scopes: Scopes.Get()),
                    RequireSsl = true
                }));

        }
    }
}