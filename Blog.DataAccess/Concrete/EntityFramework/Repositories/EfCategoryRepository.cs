using Blog.DataAccess.Abstract;
using Blog.DataAccess.Concrete.EntityFramework.Context;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepository<Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            using var context = new BlogContext();
            return await context.Categories.OrderByDescending(I => I.CategoryId).Include(I => I.CategoryBlogs).ToListAsync();
        }
    }
}
