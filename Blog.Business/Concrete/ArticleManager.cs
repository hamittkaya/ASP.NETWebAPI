using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.DTO.DTOs.CategoryBlogDtos;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class ArticleManager : GenericManager<Article>, IArticleService
    {
        private readonly IEntityRepository<Article> _entityRepository;
        private readonly IEntityRepository<CategoryBlog> _categoryBlogService;
        private readonly IArticleDal _articleDal;
        public ArticleManager(IEntityRepository<Article> entityRepository, IEntityRepository<CategoryBlog> categoryBlogService, IArticleDal articleDal) : base(entityRepository)
        {
            _entityRepository = entityRepository;
            _categoryBlogService = categoryBlogService;
            _articleDal = articleDal;
        }

        public async Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var control = await _categoryBlogService.GetAsync(I => I.CategoryId == categoryBlogDto.CategoryId && I.BlogId == categoryBlogDto.ArticleId);
            if (control == null)
            {
                await _categoryBlogService.AddAsync(new CategoryBlog
                {
                    BlogId = categoryBlogDto.ArticleId,
                    CategoryId = categoryBlogDto.CategoryId
                });
            }
        }

        public async Task<List<Article>> GetAllByCategoryIdAsync(int categoryId)
        {
            return await _articleDal.GetAllByCategoryIdAsync(categoryId);
        }

        public async Task<List<Article>> GetAllSortedByPostedTimeAsync()
        {
            return await _entityRepository.GetAllAsync(I => I.PostedTime);
        }

        public async Task RemoveToCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var deletedCategoryBlog = await _categoryBlogService.GetAsync(I => I.CategoryId == categoryBlogDto.CategoryId && I.BlogId == categoryBlogDto.ArticleId);
            if (deletedCategoryBlog != null)
            {
                await _categoryBlogService.RemoveAsync(deletedCategoryBlog);
            }
        }
    }
}
