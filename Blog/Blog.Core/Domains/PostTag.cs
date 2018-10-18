namespace Blog.Core.Domains
{
    public class PostTag : Entity<long>
    {
        public Post Post { get; set; }

        public long TagId { get; set; }
        public Tag Tag { get; set; }
    }
}