using Blog.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DTO.DTOs.UserDtos
{
    public class UserLoginDto 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
