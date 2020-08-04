using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly IEntityRepository<Category> _entityRepository;
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(IEntityRepository<Category> entityRepository,ICategoryDal categoryDal) : base(entityRepository)
        {
            _entityRepository = entityRepository;
            _categoryDal = categoryDal;
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
            return await _entityRepository.GetAllAsync(I => I.CategoryId);
        }

        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            return await _categoryDal.GetAllWithCategoryBlogsAsync();
        }
    }
}
