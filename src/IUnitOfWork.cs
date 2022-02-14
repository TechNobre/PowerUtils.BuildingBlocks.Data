using System;
using System.Threading;
using System.Threading.Tasks;

namespace PowerUtils.BuildingBlocks.Data
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> CommitAsync(CancellationToken cancellationToken = default);
        Task RollbackAsync(CancellationToken cancellationToken = default);
    }
}
