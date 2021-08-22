using Core;
using Core.Repositories;
using MyProject.Persistence.Repositories;

namespace MyProject.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectDbContext _context;


        public UnitOfWork(ProjectDbContext context)
        {
            _context = context;
            Blogs = new BlogRepository(context);
            Posts = new PostRepository(context);
        }

        public IBlogRepository Blogs { get; set; }
        public IPostRepository Posts { get; set; }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}