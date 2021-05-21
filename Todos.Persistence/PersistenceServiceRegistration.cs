using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Todos.Application.Contracts.Persistence;
using Todos.Application.Contracts.Persistence.Common;
using Todos.Persistence.Repositories;

namespace Todos.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TicketDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString(""));
            });
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
