using System;

namespace Blog.Core.Domains
{
    public class Comment : Entity<long>, IDateTracking, IHasOwner
    {
        public long PostId { get; set; }
        public string Content { get; set; }
        public bool IsApproved { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public long ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}