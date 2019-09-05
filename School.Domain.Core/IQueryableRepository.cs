using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    public interface IQueryableRepository<TFilter>
    {
        Task<IEnumerable<TFilter>> SearchAsync(TFilter filter, int fromPage = 0, int size = 0, string[] sortBy = null);

    }
}
