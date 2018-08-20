using Blog.Core;

namespace Blog.EntityFrameworkCore.Repositories
{
    public interface IBlogRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        IUnitOfWork UnitOfWork { get; }
    }

    public interface IBlogRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
