using System;

namespace Todos.Application.Features.Users.Queries
{
    public class UserListVm
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}