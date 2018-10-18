using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Blog.EntityFrameworkCore.Extensions
{
    public class BlogDbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
    {
        public BlogDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BlogDbContext>();

            builder.UseSqlServer("Server=NTTHINH-PC\\SQL2K14;Database=Blog;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new BlogDbContext(builder.Options);
        }
    }
}
