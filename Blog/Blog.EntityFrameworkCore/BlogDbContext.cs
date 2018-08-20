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

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PostMap());
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
