
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace lab3.Models
{
           public class EmploeeContext : DbContext
        {
        public EmploeeContext(DbContextOptions<EmploeeContext> options) : base (options)
        {
        }
        public DbSet<Employee> Employees { get; set; } = null!;
            public DbSet<Post> Posts { get; set; } = null!;
        }
}