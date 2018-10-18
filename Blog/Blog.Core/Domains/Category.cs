using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Core.Domains
{
  public  class Category:Entity<long>,IDateTracking,IHasOwner
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public bool IsApproved { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public long CreatedBy { get; set; }

        public long ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
