using Pizza4Ps.StaffService.Domain.Abstractions.Services.ServiceBase;
using Pizza4Ps.StaffService.Domain.Enums;

namespace Pizza4Ps.StaffService.Domain.Abstractions.Services
{
    public interface IShiftRegistrationService : IDomainService
    {
        Task<Guid> CreateAsync(Guid staffId, Guid dayId, Guid shiftId);
        Task<Guid> UpdateAsync(Guid id, Guid staffId, Guid dayId, Guid shiftId, Guid roleId);
        Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false);
        Task RestoreAsync(List<Guid> ids);
    }
}
