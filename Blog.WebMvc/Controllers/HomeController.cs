using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.WebMvc.ApiServices.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleApiService _articleApiService;
        public HomeController(IArticleApiService articleApiService)
        {
            _articleApiService = articleApiService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _articleApiService.GetAllAsync());
        }
    }
}