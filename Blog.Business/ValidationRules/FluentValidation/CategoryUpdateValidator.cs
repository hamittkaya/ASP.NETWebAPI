using Blog.DTO.DTOs.CategoryDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class CategoryUpdateValidator: AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(I => I.CategoryId).InclusiveBetween(0, int.MaxValue).WithMessage("Id cannot be empty");
            RuleFor(I => I.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
