using CleanArchitecture.Application.UseCases.GetAllUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases.DeleteUser;

public class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
{
    public DeleteUserValidator()
    {
        RuleFor(x => x.Id).NotEmpty(); 
    }
}
