using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrationTest
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Company> Company { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
