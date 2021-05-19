using MediatR;
using System.Collections.Generic;

namespace Todos.Application.Features.Users.Queries
{
    public class GetAllUsersQuery:IRequest<List<UserListVm>>
    {
    }
}
