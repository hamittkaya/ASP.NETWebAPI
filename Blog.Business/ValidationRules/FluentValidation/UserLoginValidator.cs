using Blog.DTO.DTOs.UserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class UserLoginValidator :AbstractValidator<UserLoginDto>
    {
        public UserLoginValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("username cannot be empty");
            RuleFor(I => I.Password).NotEmpty().WithMessage("password cannot be empty");
        }
    }
}
