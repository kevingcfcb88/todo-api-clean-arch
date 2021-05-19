using AutoMapper;
using Todos.Application.Features.Users.Commands.CreateUser;
using Todos.Application.Features.Users.Queries;
using Todos.Domain.Entities;

namespace Todos.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserListVm>().ReverseMap();
            CreateMap<CreateUserCommand, User>().ReverseMap();
        }
    }
}
