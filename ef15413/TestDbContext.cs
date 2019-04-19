using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ef15413
{
    public class TestDbContext : DbContext
    {
        public DbSet<TestModel> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(w => w.Ignore(RelationalEventId.AmbientTransactionWarning));
            optionsBuilder.UseSqlite(new SqliteConnectionStringBuilder { DataSource = "test.db" }.ConnectionString);
        }
    }
}
