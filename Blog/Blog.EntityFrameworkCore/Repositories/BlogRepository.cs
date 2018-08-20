using Blog.Core;

namespace Blog.EntityFrameworkCore.Repositories
{
    public class BlogRepository<TEntity> :
          EfCoreRepository<BlogDbContext, TEntity, int>,
          IBlogRepository<TEntity> where TEntity : class, IEntity<int>
    {
        private readonly BlogDbContext _db;

        public BlogRepository(BlogDbContext db) : base(db)
        {
            _db = db;
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _db;
            }
        }
    }

    public class AppRepository<TEntity, TId> :
        EfCoreRepository<BlogDbContext, TEntity, TId>,
        IBlogRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        private readonly BlogDbContext _db;

        public AppRepository(BlogDbContext db) : base(db)
        {
            _db = db;
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _db;
            }
        }
    }
}
