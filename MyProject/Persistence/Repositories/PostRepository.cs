using System.Collections.Generic;
using System.Linq;
using Core.Models;
using Core.Repositories;
using Core.Specifications;

namespace MyProject.Persistence.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(IProjectDbContext context) : base(context)
        {
        }

        public IReadOnlyList<Post> GetList(Specification<Post> specification)
        {
            return Context
                .Posts
                .Where(specification.ToExpression())
                .ToList();
        }
    }
}