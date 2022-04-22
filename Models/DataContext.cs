using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserTests.Models
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestQuestion> Questions { get; set; }
        public DbSet<TestAnswer> Answers { get; set; }
        public DbSet<AppUserTestJunction> UserTests { get; set; }
    }
}