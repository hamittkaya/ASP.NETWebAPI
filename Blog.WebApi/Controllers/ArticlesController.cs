using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Business.Abstract;
using Blog.DTO.DTOs.ArticleDtos;
using Blog.DTO.DTOs.CategoryBlogDtos;
using Blog.Entities.Concrete;
using Blog.WebApi.CustomFilters;
using Blog.WebApi.Enums;
using Blog.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : BaseController
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;
        public ArticlesController(IArticleService articleService, IMapper mapper)
        {
            _mapper = mapper;
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<ArticleListDto>>(await _articleService.GetAllSortedByPostedTimeAsync()));
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Article>))]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<ArticleListDto>(await _articleService.FindByIdAsync(id)));
        }

        [HttpPost]
        //[Authorize]
        [ValidModel]
        public async Task<IActionResult> Create([FromForm]ArticleAddModel articleAddModel)
        {
            var uploadModel = await UploadFileAsync(articleAddModel.Image, "image/jpeg");
            if (uploadModel.UploadState == UploadState.Success)
            {
                articleAddModel.ImagePath = uploadModel.NewName;
                await _articleService.AddAsync(_mapper.Map<Article>(articleAddModel));
                return Created("", articleAddModel);
            }
            else if (uploadModel.UploadState == UploadState.NotExist)
            {
                await _articleService.AddAsync(_mapper.Map<Article>(articleAddModel));
                return Created("", articleAddModel);
            }
            else
            {
                return BadRequest(uploadModel.ErrorMessage);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        [ValidModel]
        [ServiceFilter(typeof(ValidId<Article>))]
        public async Task<IActionResult> Update(int id, [FromForm]ArticleUpdateModel articleUpdateModel)
    
        {
            if (id != articleUpdateModel.ArticleId)
                return BadRequest("invalid id");
            var uploadModel = await UploadFileAsync(articleUpdateModel.Image, "image/jpeg");

            if (uploadModel.UploadState == UploadState.Success)
            {
                var updatedBlog = await _articleService.FindByIdAsync(articleUpdateModel.ArticleId);

                updatedBlog.ShortDescription = articleUpdateModel.ShortDescription;
                updatedBlog.Title = articleUpdateModel.Title;
                updatedBlog.Description = articleUpdateModel.Description;
                updatedBlog.ImagePath = uploadModel.NewName;


                await _articleService.UpdateAsync(updatedBlog);
                return NoContent();
            }
            else if (uploadModel.UploadState == UploadState.NotExist)
            {
                var updatedBlog = await _articleService.FindByIdAsync(articleUpdateModel.ArticleId);
                updatedBlog.ShortDescription = articleUpdateModel.ShortDescription;
                updatedBlog.Title = articleUpdateModel.Title;
                updatedBlog.Description = articleUpdateModel.Description;

                await _articleService.UpdateAsync(updatedBlog);
                return NoContent();
            }
            else
            {
                return BadRequest(uploadModel.ErrorMessage);
            }
        }

        [HttpDelete]
        [Authorize]
        [ServiceFilter(typeof(ValidId<Article>))]
        public async Task<IActionResult> Delete(int id)
        {
            await _articleService.RemoveAsync(new Article { ArticleId = id });
            return NoContent();
        }

        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> AddToCategory(CategoryBlogDto categoryBlogDto)
        {
            await _articleService.AddToCategoryAsync(categoryBlogDto);
            return Created("", categoryBlogDto);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveFromCategory([FromQuery]CategoryBlogDto categoryBlogDto)
        {
            await _articleService.RemoveToCategoryAsync(categoryBlogDto);
            return NoContent();
        }
        [HttpGet("[action]/{id}")]
        [ServiceFilter(typeof(ValidId<Category>))]
        public async Task<IActionResult> GetAllByCategoryId(int id)
        {
            return Ok(await _articleService.GetAllByCategoryIdAsync(id));

        }

    }
}