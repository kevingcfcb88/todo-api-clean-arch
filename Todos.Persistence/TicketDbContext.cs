using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using Todos.Domain.Common;
using Todos.Domain.Entities;

namespace Todos.Persistence
{
    public class TicketDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public TicketDbContext(DbContextOptions<TicketDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TicketDbContext).Assembly);

            var userId = Guid.Parse("{0f8fad5b-d9cb-469f-a165-70867728950e}");

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = userId,
                FirstName = "Admin",
                LastName = "Admin",
                UserName = "admin"
            });
        }

        /// <summary>
        /// Method that overwrite the entity to be saved and add the auditable fields
        /// </summary>
        /// <param name="token">Cancellation Token required for the original method</param>
        /// <returns>The number of entries wrote in the database</returns>
        public override Task<int> SaveChangesAsync(CancellationToken token = new CancellationToken())
        {
            foreach (var record in ChangeTracker.Entries<BaseEntity>())
            {
                switch (record.State)
                {
                    case EntityState.Added:
                        record.Entity.Status = true;
                        record.Entity.Created_at = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        record.Entity.Modified_at = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(token);
        }
    }
}
