using Microsoft.EntityFrameworkCore;

namespace Academy_ASP_NET_Homework_Course.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string DbPath;
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
