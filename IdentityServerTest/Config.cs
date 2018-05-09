using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServerTest
{
    public class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource> { new IdentityResources.OpenId(), new IdentityResources.Profile(), new IdentityResources.Email() };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "IdentityServerTestApp",
                    ClientName = "IdentityServerTest",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    RedirectUris = { "http://localhost:5001/signin-oidc" },
                    PostLogoutRedirectUris = { "http://localhost:5001/signout-callback-oidc" },
                    AllowedScopes = {IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Profile, IdentityServerConstants.StandardScopes.Email}
                }
            };
        }

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "identityServerTest",
                    Password = "identityServerTest",
                    Claims = new List<Claim>
                    {
                        new Claim("name","Identity Server Test Portal"),
                        new Claim("website","https://imasters.com.br"),
                        new Claim("email","henrique@tecnomips.com.br")
                    }
                }
            };
        }


    }
}
