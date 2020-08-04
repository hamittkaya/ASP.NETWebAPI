using Blog.WebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebMvc.ApiServices.Abstract
{
    public interface IArticleApiService
    {
        Task<List<ArticleListModel>> GetAllAsync();
    }
}
