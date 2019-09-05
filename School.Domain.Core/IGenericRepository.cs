using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    public interface IGenericRepository<T>
    {
        Task CreateAsync(T newObject);
        Task UpdateAsync(T updatedObject);
        Task DeleteAsync(Guid guid);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
    }
}
