using System;
using System.Linq.Expressions;
using Core.Models;

namespace Core.Specifications
{
    public sealed class PostsWithNoContentSpecification : Specification<Post>
    {
        public override Expression<Func<Post, bool>> ToExpression()
        {
            return post => string.IsNullOrWhiteSpace(post.Content);
        }
    }
    public sealed class ThisMonthPostsSpecification : Specification<Post>
    {
        public override Expression<Func<Post, bool>> ToExpression()
        {
            return post => post.DateTime.Month == DateTime.Now.Month;
        }
    }
}