using Core.Models;
using Core.Repositories;

namespace MyProject.Persistence.Repositories
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        public BlogRepository(IProjectDbContext context) : base(context)
        {
        }
    }
}