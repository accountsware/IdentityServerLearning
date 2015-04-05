using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServerLearning.Identity.Configuration;
using Owin;
using Thinktecture.IdentityServer.Core.Configuration;

namespace IdentityServerLearning.Identity
{
    public sealed class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/myHome",
                coreApp => coreApp.UseIdentityServer(new IdentityServerOptions
                {
                    SiteName = "MBS Identity Server",
                    SigningCertificate = Cert.Load(),
                    Factory = InMemoryFactory.Create(Users.Get(), Clients.Get(), Scopes.Get()),
                    RequireSsl = true
                }));

        }
    }
}