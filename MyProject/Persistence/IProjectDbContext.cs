using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Persistence
{
    public interface IProjectDbContext
    {
        DbSet<Post> Posts { get; set; }
        DbSet<Blog> Blogs { get; set; }


        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}