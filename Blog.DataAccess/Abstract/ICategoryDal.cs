﻿using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Abstract
{
    public interface ICategoryDal :IEntityRepository<Category>
    {
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}
