using CleanArchitecture.Application.UseCases.UpdateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases.DeleteUser;

public sealed record DeleteUserRequest(Guid Id)
                     : IRequest<DeleteUserResponse>;

