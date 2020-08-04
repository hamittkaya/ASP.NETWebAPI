﻿using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class Comment : IEntity
    {
        public int CommentId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

        public List<Comment> SubComments { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
