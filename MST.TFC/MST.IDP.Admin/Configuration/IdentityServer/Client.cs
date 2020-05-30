using System.Collections.Generic;
using MST.IDP.Admin.Configuration.Identity;

namespace MST.IDP.Admin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}






