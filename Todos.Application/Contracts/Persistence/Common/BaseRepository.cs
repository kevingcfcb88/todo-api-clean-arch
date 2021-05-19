using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Todos.Application.Contracts.Persistence.Common
{
    public interface BaseRepository<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}
