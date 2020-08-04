using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.StringInfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:64061";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "hamit321";
        public const double Expires = 40;
    }
}
