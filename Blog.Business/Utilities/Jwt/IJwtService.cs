using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Utilities.Jwt
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(User user);
    }
}
