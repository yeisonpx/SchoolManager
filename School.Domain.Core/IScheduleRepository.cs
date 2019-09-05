using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Domain.Calendar;

namespace School.Domain.Core
{
    public interface IScheduleRepository : IGenericRepository<Schedule>, IQueryableRepository<Schedule>
    {

    }
}
