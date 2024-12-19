using Pizza4Ps.StaffService.Domain.Abstractions.Services.ServiceBase;

namespace Pizza4Ps.StaffService.Domain.Abstractions.Services
{
	public interface IStoreService : IDomainService
	{
		Task<Guid> CreateAsync();
		Task<Guid> UpdateAsync(Guid id);
		Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false);
		Task RestoreAsync(List<Guid> ids);
	}
}
