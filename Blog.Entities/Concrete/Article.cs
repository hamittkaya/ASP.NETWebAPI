using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class Article : IEntity
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User User { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
