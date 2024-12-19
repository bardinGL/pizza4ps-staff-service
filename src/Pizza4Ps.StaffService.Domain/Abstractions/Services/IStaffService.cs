using Pizza4Ps.StaffService.Domain.Abstractions.Services.ServiceBase;
using Pizza4Ps.StaffService.Domain.Enums;

namespace Pizza4Ps.StaffService.Domain.Abstractions.Services
{
	public interface IStaffService : IDomainService
	{
		Task<Guid> CreateAsync(string code, string name, string phone, string email, StaffEnum.StaffType staffType, StaffEnum.StaffStatus status);
		Task<Guid> UpdateAsync(Guid id, string code, string name, string phone, string email, StaffEnum.StaffType staffType, StaffEnum.StaffStatus status);
		Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false);
		Task RestoreAsync(List<Guid> ids);
	}
}
