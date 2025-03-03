using Pizza4Ps.StaffService.Domain.Abstractions.Services.ServiceBase;

namespace Pizza4Ps.StaffService.Domain.Abstractions.Services
{
    public interface IShiftScheduleService : IDomainService
    {
        Task<Guid> CreateAsync(Guid staffId, Guid dayId, Guid shiftId, DateTimeOffset shiftStart, DateTimeOffset shiftEnd);
        Task<Guid> UpdateAsync(Guid id, Guid staffId, Guid dayId, Guid shiftId, DateTimeOffset shiftStart, DateTimeOffset shiftEnd);
        Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false);
        Task RestoreAsync(List<Guid> ids);
    }
}
