using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfUserRepository :EfEntityRepository<User>,IUserDal
    {
    }
}
