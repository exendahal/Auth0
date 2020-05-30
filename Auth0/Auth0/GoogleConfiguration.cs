using System;
using System.Collections.Generic;
using System.Text;

namespace Auth0
{
    public static class GoogleConfiguration
    {
        public static readonly string ClientId = "Your client ID";
        public static readonly string Scope = "email";
        public static readonly string ClientSecret = "";
        public static readonly string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
        public static readonly string RedirectUrl = "";
        public static readonly string AcessTokenUrl = "https://oauth2.googleapis.com/token";
        public static bool IsUsingNativeUI = true;
    }
}
