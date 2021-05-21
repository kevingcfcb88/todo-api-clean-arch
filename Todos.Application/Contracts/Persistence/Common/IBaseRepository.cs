using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Todos.Application.Contracts.Persistence.Common
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
