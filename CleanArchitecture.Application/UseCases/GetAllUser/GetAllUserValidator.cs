using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases.GetAllUser;
    public class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
    {
        public GetAllUserValidator() 
        {
            // sem validações
        }
    }
