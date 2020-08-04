using Blog.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DTO.DTOs.CategoryDtos
{
    public class CategoryUpdateDto :IDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
