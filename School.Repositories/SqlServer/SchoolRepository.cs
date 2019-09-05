using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain;
using School.Domain.Core;

namespace School.Repositories.SqlServer
{
    public class SchoolRepository : GenericRepository<Domain.School>, ISchoolRepository, IQueryableRepository<Domain.School>
    {
        private readonly SqlDbContext _db;

        public SchoolRepository(SqlDbContext sqlDbContext):
            base(sqlDbContext)
        {
            this._db = sqlDbContext;
        }

        public async Task<IEnumerable<Domain.School>> SearchAsync(Domain.School filter, int fromPage = 0, int size = 0, string[] sortBy = null)
        {
            throw new NotImplementedException();
        }

    }
}
