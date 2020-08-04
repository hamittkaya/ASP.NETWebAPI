using Blog.DTO.DTOs.UserDtos;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> CheckUserAsync(UserLoginDto userLoginDto);
        Task<User> FindByNameAsync(string userName);
    }
}
