using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Abstractions;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;
using Pizza4Ps.StaffService.Domain.Services.ServiceBase;

namespace Pizza4Ps.StaffService.Domain.Services
{
	public class StoreService : DomainService, IStoreService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IStoreRepository _storeRepository;

		public StoreService(IUnitOfWork unitOfWork, IStoreRepository storeRepository)
		{
			_unitOfWork = unitOfWork;
			_storeRepository = storeRepository;
		}

		public async Task<Guid> CreateAsync()
		{
			throw new NotImplementedException();
		}

		public async Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false)
		{
			throw new NotImplementedException();
		}

		public async Task RestoreAsync(List<Guid> ids)
		{
			throw new NotImplementedException();
		}

		public async Task<Guid> UpdateAsync(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
