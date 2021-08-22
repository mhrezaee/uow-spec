using Core.Repositories;

namespace Core
{
    public interface IUnitOfWork
    {

        IBlogRepository Blogs { get; set; }
        IPostRepository Posts { get; set; }

        void Commit();
    }
}