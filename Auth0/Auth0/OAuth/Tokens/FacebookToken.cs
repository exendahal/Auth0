using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth0.OAuth.Data
{
    public class FacebookToken
    {
        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }
        [JsonProperty("access_token")]
        public string AccessToken
        {
            get;
            set;
        }

        [JsonProperty("expires_in")]
        public string ExpiresIn
        {
            get;
            set;
        }

        [JsonProperty("reauthorize_required_in")]
        public string ReauthorizeRequiredIn
        {
            get;
            set;
        }

        [JsonProperty("data_access_expiration_time")]
        public string DataAccessExpirationTime
        {
            get;
            set;
        }
    }
}
