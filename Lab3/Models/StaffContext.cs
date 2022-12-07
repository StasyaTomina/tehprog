using Microsoft.EntityFrameworkCore;

namespace lab3.Models
{
           public class StaffContext : DbContext
        {
        public StaffContext(DbContextOptions<StaffContext> options) : base (options)
        {
        }
        public DbSet<Staff> Staffs { get; set; } = null!;
            public DbSet<Post> Posts { get; set; } = null!;
        }
}