using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todos.Application.Contracts.Persistence.Common;

namespace Todos.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly TicketDbContext _ticketDbContext;

        public BaseRepository(TicketDbContext ticketDbContext)
        {
            _ticketDbContext = ticketDbContext;
        }

        public async Task<T> GetById(Guid id)
        {
            return await _ticketDbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _ticketDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Create(T entity)
        {
            await _ticketDbContext.Set<T>().AddAsync(entity);
            await _ticketDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task Update(T entity)
        {
            _ticketDbContext.Entry(entity).State = EntityState.Modified;
            await _ticketDbContext.SaveChangesAsync(); ;
        }

        public async Task Delete(T entity)
        {
            _ticketDbContext.Set<T>().Remove(entity);
            await _ticketDbContext.SaveChangesAsync();
        }
    }
}
