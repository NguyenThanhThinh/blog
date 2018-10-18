using System.Collections.Generic;

namespace Blog.Core.Domains
{
    public class Tag:Entity<long>
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public bool IsApproved { get; set; }

        public ICollection<PostTag> Posts { get; set; } = new List<PostTag>();
    }
}
