using System.Threading.Tasks;
using Blog.Core;
using Blog.Core.Domains;
using Blog.Core.Domains.Identities;
using Blog.EntityFrameworkCore.Extensions;
using Blog.EntityFrameworkCore.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore
{
    public class BlogDbContext : IdentityDbContext<
            User,
            Role,
            long,
            UserClaim,
            UserRole,
            UserLogin,
            RoleClaim,
            UserToken>,
        IUnitOfWork

    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<PostTag> PostTags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserClaimMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserLoginMap());
            modelBuilder.ApplyConfiguration(new RoleClaimMap());
            modelBuilder.ApplyConfiguration(new UserTokenMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new PostTagMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            // etc....
        }

        public void Commit()
        {
            base.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}