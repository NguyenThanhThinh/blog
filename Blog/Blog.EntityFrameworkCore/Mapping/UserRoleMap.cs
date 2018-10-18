using Blog.Core.Domains.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.EntityFrameworkCore.Mapping
{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> b)
        {
            b.HasKey(ur => new {ur.UserId, ur.RoleId});
            b.HasOne(ur => ur.Role).WithMany(x => x.Users).HasForeignKey(r => r.RoleId);
            b.HasOne(ur => ur.User).WithMany(x => x.Roles).HasForeignKey(u => u.UserId);
            b.ToTable("UserRole");
        }
    }
}