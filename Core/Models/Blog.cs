using System.Collections.Generic;

namespace Core.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public ICollection<Post> Posts { get; } = new List<Post>();
    }
}