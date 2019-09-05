using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain.Core;
using School.Repositories.SqlServer;
using School.Domain.Calendar;
namespace Schedule.Repositories.SqlServer
{
    public class ScheduleRepository : GenericRepository<School.Domain.Calendar.Schedule>, IScheduleRepository,  IQueryableRepository<School.Domain.Calendar.Schedule>
    {
        private readonly SqlDbContext _db;

        public ScheduleRepository(SqlDbContext sqlDbContext):
            base(sqlDbContext)
        {
            this._db = sqlDbContext;
        }

        public async Task<IEnumerable<School.Domain.Calendar.Schedule>> SearchAsync(School.Domain.Calendar.Schedule filter, int fromPage = 0, int size = 0, string[] sortBy = null)
        {
            throw new NotImplementedException();
        }

    }
}
