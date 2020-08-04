using AutoMapper;
using Blog.DTO.DTOs.ArticleDtos;
using Blog.DTO.DTOs.CategoryDtos;
using Blog.Entities.Concrete;
using Blog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            CreateMap<ArticleListDto, Article>();
            CreateMap<Article, ArticleListDto>();

            CreateMap<ArticleUpdateModel, Article>();
            CreateMap<Article, ArticleUpdateModel>();

            CreateMap<ArticleAddModel, Article>();
            CreateMap<Article, ArticleAddModel>();

            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();

            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();
        }
    }
}
