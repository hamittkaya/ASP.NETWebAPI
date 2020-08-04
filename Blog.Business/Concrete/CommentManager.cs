using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>,ICommentService
    {
        private readonly IEntityRepository<Comment> _entityRepository;
        public CommentManager(IEntityRepository<Comment> entityRepository) : base(entityRepository)
        {
            _entityRepository = entityRepository;
        }
    }
}
