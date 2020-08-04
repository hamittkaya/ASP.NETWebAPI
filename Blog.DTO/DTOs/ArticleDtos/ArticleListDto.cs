using Blog.DTO.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DTO.DTOs.ArticleDtos
{
    public class ArticleListDto :IDto
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; }

      
    }
}
