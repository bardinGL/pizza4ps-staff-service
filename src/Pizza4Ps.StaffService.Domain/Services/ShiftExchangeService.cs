using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Abstractions;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;
using Pizza4Ps.StaffService.Domain.Services.ServiceBase;

namespace Pizza4Ps.StaffService.Domain.Services
{
	public class ShiftExchangeService : DomainService, IShiftExchangeService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IShiftExchangeRepository _shiftExchangeRepository;

		public ShiftExchangeService(IUnitOfWork unitOfWork, IShiftExchangeRepository shiftExchangeRepository)
		{
			_unitOfWork = unitOfWork;
			_shiftExchangeRepository = shiftExchangeRepository;
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
