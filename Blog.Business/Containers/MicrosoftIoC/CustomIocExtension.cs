using Blog.Business.Abstract;
using Blog.Business.Concrete;
using Blog.Business.Utilities.Jwt;
using Blog.Business.ValidationRules.FluentValidation;
using Blog.DataAccess.Abstract;
using Blog.DataAccess.Concrete.EntityFramework.Repositories;
using Blog.DTO.DTOs.CategoryBlogDtos;
using Blog.DTO.DTOs.CategoryDtos;
using Blog.DTO.DTOs.CommentDtos;
using Blog.DTO.DTOs.UserDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Containers.MicrosoftIoC
{
    public static class CustomIocExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEntityRepository<>), typeof(EfEntityRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScoped<IArticleDal, EfArticleRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserRepository>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentRepository>();

            services.AddScoped<IJwtService, JwtManager>();
            //services.AddScoped<ICustomLogger, NLogAdapter>();

            services.AddTransient<IValidator<UserLoginDto>, UserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<CommentAddDto>, CommentAddValidator>();
        }
    }
}
