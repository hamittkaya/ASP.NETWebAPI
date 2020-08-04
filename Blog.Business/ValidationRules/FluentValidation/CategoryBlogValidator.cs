﻿using Blog.DTO.DTOs.CategoryBlogDtos;
using Blog.DTO.DTOs.UserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class CategoryBlogValidator: AbstractValidator<CategoryBlogDto>
    {
        public CategoryBlogValidator()
        {
            RuleFor(I => I.CategoryId).InclusiveBetween(0, int.MaxValue).WithMessage("CategoryId cannot be empty");
            RuleFor(I => I.ArticleId).InclusiveBetween(0, int.MaxValue).WithMessage("BlogId cannot be empty");
        }
    }
}
