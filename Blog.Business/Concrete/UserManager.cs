using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.DTO.DTOs.UserDtos;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class UserManager :GenericManager<User>,IUserService
    {
        private readonly IEntityRepository<User> _entityRepository;
        public UserManager(IEntityRepository<User> entityRepository) : base(entityRepository)
        {
            _entityRepository = entityRepository;    
        }

        public async Task<User> CheckUserAsync(UserLoginDto userLoginDto)
        {
            return await _entityRepository.GetAsync(I => I.UserName == userLoginDto.UserName && I.Password == userLoginDto.Password);
        }

        public async Task<User> FindByNameAsync(string userName)
        {
            return await _entityRepository.GetAsync(I => I.UserName == userName);
        }
    }
}
