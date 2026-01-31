using CleanArchitecture.Application.UseCases.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases.UpdateUser;

public sealed record UpdateUserRequest(Guid Id, 
                     string Email, string Name) 
                     : IRequest<UpdateUserResponse>;
