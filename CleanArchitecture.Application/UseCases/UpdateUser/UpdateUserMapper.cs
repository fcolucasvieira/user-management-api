using AutoMapper;
using CleanArchitecture.Application.UseCases.CreateUser;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases.UpdateUser;

public sealed class UpdateUserMapper : Profile
{
    public UpdateUserMapper()
    {
        CreateMap<UpdateUserRequest, User>();
        CreateMap<User, UpdateUserResponse>();
    }
}
