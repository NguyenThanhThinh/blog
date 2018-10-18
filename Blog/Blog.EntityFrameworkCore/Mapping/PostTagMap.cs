using Blog.Core.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.EntityFrameworkCore.Mapping
{
    public class PostTagMap : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.HasKey(pt => new { pt.PostId, pt.TagId });
            builder.HasOne(pt => pt.Post).WithMany(x => x.Tags).HasForeignKey(r => r.PostId);
            builder.HasOne(pt => pt.Tag).WithMany(x => x.Posts).HasForeignKey(u => u.TagId);
            builder.ToTable("PostTag");

        }
    }
}
