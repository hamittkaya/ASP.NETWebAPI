using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Abstract
{
    public interface ICommentDal : IEntityRepository<Comment>
    {
    }
}
