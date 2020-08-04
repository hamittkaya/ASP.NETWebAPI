using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IArticleService _articleService;
        public ImagesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetBlogImageId(int id)
        {
            var blog = await _articleService.FindByIdAsync(id);
            if (string.IsNullOrWhiteSpace(blog.ImagePath))
                return NotFound("image not found");
            return File($"/img/{blog.ImagePath}", "image/jpeg");
        }
    }
}