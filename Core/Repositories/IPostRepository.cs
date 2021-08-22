using System.Collections.Generic;
using Core.Models;
using Core.Specifications;

namespace Core.Repositories
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        IReadOnlyList<Post> GetList(Specification<Post> specification);
    }
}