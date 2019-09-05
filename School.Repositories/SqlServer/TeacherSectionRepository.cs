using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain.Core;
using School.Repositories.SqlServer;
namespace Teacher.Repositories.SqlServer
{
    public class TeacherSectionRepository : GenericRepository<School.Domain.TeacherSection>, IQueryableRepository<School.Domain.TeacherSection>
    {
        private readonly SqlDbContext _db;

        public TeacherSectionRepository(SqlDbContext sqlDbContext):
            base(sqlDbContext)
        {
            this._db = sqlDbContext;
        }

        public async Task<IEnumerable<School.Domain.TeacherSection>> SearchAsync(School.Domain.TeacherSection filter, int fromPage = 0, int size = 0, string[] sortBy = null)
        {
            throw new NotImplementedException();
        }

    }
}
