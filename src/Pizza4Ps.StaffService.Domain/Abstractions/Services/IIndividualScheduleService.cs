using Pizza4Ps.StaffService.Domain.Abstractions.Services.ServiceBase;

namespace Pizza4Ps.StaffService.Domain.Abstractions.Services
{
	public interface IIndividualScheduleService : IDomainService
	{
		Task<Guid> CreateAsync(DateTimeOffset schedualDate, TimeSpan shiftStart, TimeSpan shiftEnd, string status, Guid staffId);
		Task<Guid> UpdateAsync(Guid id, DateTimeOffset schedualDate, TimeSpan shiftStart, TimeSpan shiftEnd, string status, Guid staffId);
		Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false);
		Task RestoreAsync(List<Guid> ids);
	}
}
