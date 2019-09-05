using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain.Core;
using School.Repositories.SqlServer;
namespace Teacher.Repositories.SqlServer
{
    public class TeacherRepository : GenericRepository<School.Domain.Teacher>, ITeacherRepository,  IQueryableRepository<School.Domain.Teacher>
    {
        private readonly SqlDbContext _db;

        public TeacherRepository(SqlDbContext sqlDbContext):
            base(sqlDbContext)
        {
            this._db = sqlDbContext;
        }

        public async Task<IEnumerable<School.Domain.Teacher>> SearchAsync(School.Domain.Teacher filter, int fromPage = 0, int size = 0, string[] sortBy = null)
        {
            throw new NotImplementedException();
        }

    }
}
