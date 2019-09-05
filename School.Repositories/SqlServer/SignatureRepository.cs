using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain.Core;
using School.Repositories.SqlServer;
namespace Signature.Repositories.SqlServer
{
    public class SignatureRepository : GenericRepository<School.Domain.Signature>, ISignatureRepository, IQueryableRepository<School.Domain.Signature>
    {
        private readonly SqlDbContext _db;

        public SignatureRepository(SqlDbContext sqlDbContext):
            base(sqlDbContext)
        {
            this._db = sqlDbContext;
        }

        public async Task<IEnumerable<School.Domain.Signature>> SearchAsync(School.Domain.Signature filter, int fromPage = 0, int size = 0, string[] sortBy = null)
        {
            throw new NotImplementedException();
        }

    }
}
