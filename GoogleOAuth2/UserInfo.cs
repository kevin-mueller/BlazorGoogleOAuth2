using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleOAuth2
{
    public class UserInfo
    {
        [JsonProperty("sub")]
        public string? Sub { get; set; }
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("given_name")]
        public string? GivenName { get; set; }
        [JsonProperty("family_name")]
        public string? FamilyName { get; set; }
        [JsonProperty("picture")]
        public string? Picture { get; set; }
        [JsonProperty("email")]
        public string? Email { get; set; }
        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }
        [JsonProperty("locale")]
        public string? Locale { get; set; }
        [JsonProperty("hd")]
        public string? Hd { get; set; }
    }

}
