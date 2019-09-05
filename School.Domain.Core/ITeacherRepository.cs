using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    public interface ITeacherRepository : IGenericRepository<Teacher>, IQueryableRepository<Teacher>
    {
      
    }
}
