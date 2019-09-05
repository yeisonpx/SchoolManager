using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    public interface ISchoolRepository : IGenericRepository<School>,IQueryableRepository<School>
    {

    }
}
