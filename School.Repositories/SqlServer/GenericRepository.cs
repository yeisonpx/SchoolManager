using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain.Core;
namespace School.Repositories.SqlServer
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity: class
    {
        private readonly DbContext _db;

        public GenericRepository(DbContext sqlServer)
        {
            this._db = sqlServer;
        }

        public async Task CreateAsync(TEntity newObject)
        {
            await _db.Set<TEntity>()
                    .AddAsync(newObject);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid guid)
        {
            var entry = await _db.Set<TEntity>()
                                    .FindAsync(guid);
            _db.Remove(entry);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await this._db.Set<TEntity>()
                .AsNoTracking()
                    .ToListAsync();
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            return await _db.Set<TEntity>()
                    .FindAsync(id);
        }


        public async Task UpdateAsync(TEntity updatedObject)
        {
            await _db.Set<TEntity>()
                     .AddAsync(updatedObject);
            await _db.SaveChangesAsync();
        }
    }
}
