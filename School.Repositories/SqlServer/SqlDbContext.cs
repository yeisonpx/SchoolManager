using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using School.Common.Settings;
using School.Domain;

namespace School.Repositories.SqlServer
{
    public class SqlDbContext : DbContext
    {
        private readonly DbSettings _settings;

        public SqlDbContext(IOptions<DbSettings> options)
        {
            this._settings = options.Value;
            
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this._settings.SqlServerConnection);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Domain.Teacher> Teachers { get; set; }
        public DbSet<Domain.School> Schools { get; set; }
        public DbSet<Domain.Signature> Signatures { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}
