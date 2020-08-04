using Blog.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DTO.DTOs.UserDtos
{
    public class UserDto :IDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
