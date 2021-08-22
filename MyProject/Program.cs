using System;
using Core;
using Core.Models;
using Core.Specifications;
using MyProject.Persistence;

namespace MyProject
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            //do not forget use DI for using unit of work, here dependency injection is out of scope
            var uow = new UnitOfWork(new ProjectDbContext());

            //define related specifications desired for the query
            var spec = new PostsWithNoContentSpecification();
            //spec.And(new ThisMonthPostsSpecification());
            
            //call the repository method with created specs.
            var posts = uow.Posts.GetList(spec);


            foreach (var post in posts)
            {
                Console.WriteLine($"{post.Title} -- Published Date: {post.DateTime}");
            }

            Console.ReadKey();

        }
    }
}
