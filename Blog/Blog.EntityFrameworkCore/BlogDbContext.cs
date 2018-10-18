using System.Threading.Tasks;
using Blog.Core;
using Blog.Core.Domains;
using Blog.Core.Domains.Identities;
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
            modelBuilder.Entity<User>(b => { b.ToTable("User"); });

            modelBuilder.Entity<Role>()
                .ToTable("Role");

            modelBuilder.Entity<UserClaim>()
                .ToTable("UserClaim");

            modelBuilder.ApplyConfiguration(new UserRoleMap());


            modelBuilder.Entity<UserLogin>()
                .ToTable("UserLogin");

            modelBuilder.Entity<RoleClaim>()
                .ToTable("RoleClaim");

            modelBuilder.Entity<UserToken>()
                .ToTable("UserToken");
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