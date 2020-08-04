using Blog.WebMvc.ApiServices.Abstract;
using Blog.WebMvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blog.WebMvc.ApiServices.Concrete
{
    public class ArticleApiManager : IArticleApiService
    {
        private readonly HttpClient _httpClient;
        public ArticleApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:64061/api/articles/");
        }
        public async Task<List<ArticleListModel>> GetAllAsync()
        {
            var responseMessage= await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<ArticleListModel>>(await responseMessage.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
