using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Persistence
{
    public class ProjectDbContext : DbContext, IProjectDbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ProjectDb;Trusted_Connection=True;");
        }

    }
}