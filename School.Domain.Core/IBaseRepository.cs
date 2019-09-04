using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    public interface IBaseAsyncRepository<T>
    {
        Task CreateAsync(T newObject);
        Task UpdateAsync(T updatedObject);
        Task DeleteAsync(Guid guid);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync();
        Task<IEnumerable<T>> SearchAsync(T filter, int fromPage=0, int size=0, string[] sortBy=null);
    }
}
