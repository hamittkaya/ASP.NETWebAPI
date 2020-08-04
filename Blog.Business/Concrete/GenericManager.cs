using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _entityRepository;
        public GenericManager(IEntityRepository<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }
        public async Task AddAsync(TEntity entity)
        {
           await _entityRepository.AddAsync(entity);
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            return await _entityRepository.FindByIdAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _entityRepository.GetAllAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            await _entityRepository.RemoveAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _entityRepository.UpdateAsync(entity);
        }
    }
}
