using Microsoft.EntityFrameworkCore;

namespace Pizza4Ps.StaffService.Domain.Abstractions
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task SaveChangeAsync(CancellationToken cancellationToken =  default);
        DbContext GetDbContext();
    }
}
