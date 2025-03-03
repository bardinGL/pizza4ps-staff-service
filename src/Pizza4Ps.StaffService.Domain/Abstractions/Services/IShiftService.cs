using Pizza4Ps.StaffService.Domain.Abstractions.Services.ServiceBase;

namespace Pizza4Ps.StaffService.Domain.Abstractions.Services
{
    public interface IShiftService : IDomainService
    {
        Task<Guid> CreateAsync(string name, string description, int capacity);
        Task<Guid> UpdateAsync(Guid id, string name, string description, int capacity);
        Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false);
        Task RestoreAsync(List<Guid> ids);
    }
}
