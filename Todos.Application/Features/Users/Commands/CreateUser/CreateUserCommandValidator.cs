using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator:AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(u => u.FirstName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} cannot be null")
                .MaximumLength(50).WithMessage("{PropertyName} cannot exceed 50 characters");

            RuleFor(u => u.LastName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} cannot be null")
                .MaximumLength(50).WithMessage("{PropertyName} cannot exceed 50 characters");

            RuleFor(u => u.UserName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} cannot be null")
                .MaximumLength(50).WithMessage("{PropertyName} cannot exceed 50 characters");
        }
    }
}
