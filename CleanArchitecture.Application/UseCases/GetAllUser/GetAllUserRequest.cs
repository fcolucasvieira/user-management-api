using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases.GetAllUser;
    public sealed record GetAllUserRequest :
                        IRequest<List<GetAllUserResponse>>;
