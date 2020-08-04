using Blog.DTO.DTOs.CommentDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class CommentAddValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(I => I.AuthorName).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(I => I.AuthorEmail).NotEmpty().WithMessage("Name cannot be empty");

            RuleFor(I => I.Description).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
