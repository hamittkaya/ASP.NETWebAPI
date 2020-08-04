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
    public class EfArticleRepository : EfEntityRepository<Article>, IArticleDal
    {
        public async Task<List<Article>> GetAllByCategoryIdAsync(int categoryId)
        {
            using var context = new BlogContext();
            return await context.Articles.Join(context.CategoryBlogs, b => b.ArticleId, cb => cb.BlogId, (blog, categoryBlog) => new
            {
                blog,
                categoryBlog
            }).Where(I => I.categoryBlog.CategoryId == categoryId).Select(I => new Article
            {
                User = I.blog.User,
                UserId = I.blog.UserId,
                CategoryBlogs = I.blog.CategoryBlogs,
                Comments = I.blog.Comments,
                Description = I.blog.Description,
                ArticleId = I.blog.ArticleId,
                ImagePath = I.blog.ImagePath,
                PostedTime = I.blog.PostedTime,
                ShortDescription = I.blog.ShortDescription,
                Title = I.blog.Title
            }).ToListAsync();
        }

        public Task<List<Category>> GetCategoriesAsync(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Article>> GetLastFiveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
