using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain.Core;
using School.Repositories.SqlServer;
namespace Teacher.Repositories.SqlServer
{
    public class SectionRepository : GenericRepository<School.Domain.Section>, ISectionRepository, IQueryableRepository<School.Domain.Section>
    {
        private readonly SqlDbContext _db;

        public SectionRepository(SqlDbContext sqlDbContext):
            base(sqlDbContext)
        {
            this._db = sqlDbContext;
        }

        public async Task<IEnumerable<School.Domain.Section>> SearchAsync(School.Domain.Section filter, int fromPage = 0, int size = 0, string[] sortBy = null)
        {
            throw new NotImplementedException();
        }

    }
}
