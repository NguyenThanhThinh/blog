using System;
using System.Threading.Tasks;

namespace Blog.Core
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();

        void Commit();
    }
}
