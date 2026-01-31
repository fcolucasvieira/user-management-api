using AutoMapper;
using CleanArchitecture.Application.UseCases.UpdateUser;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.UseCases.DeleteUser;
public sealed class DeleteUserMapper : Profile
{
    public DeleteUserMapper()
    {
        CreateMap<DeleteUserRequest, User>();
        CreateMap<User, DeleteUserResponse>();
    }
}
