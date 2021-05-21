using Todos.Application.Contracts.Persistence.Common;
using Todos.Domain.Entities;

namespace Todos.Application.Contracts.Persistence
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
