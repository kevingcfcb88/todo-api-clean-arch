using Todos.Application.Contracts.Persistence;
using Todos.Domain.Entities;

namespace Todos.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(TicketDbContext dbContext) : base(dbContext)
        {

        }
    }
}
