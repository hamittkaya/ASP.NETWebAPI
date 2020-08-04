using Blog.DTO.DTOs.CategoryBlogDtos;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{
    public interface IArticleService :IGenericService<Article>
    {
        Task<List<Article>> GetAllSortedByPostedTimeAsync();
        Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task RemoveToCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task<List<Article>> GetAllByCategoryIdAsync(int categoryId);
        //Task<List<Category>> GetCategoriesAsync(int blogId);
        //Task<List<Blog>> GetLastFiveAsync();
        //Task<List<Blog>> SearchAsync(string searchString);
    }
}
