using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;
using Pizza4Ps.StaffService.Domain.Abstractions;
using Pizza4Ps.StaffService.Domain.Constants;
using Pizza4Ps.StaffService.Domain.Entities;
using Pizza4Ps.StaffService.Domain.Exceptions;
using Pizza4Ps.StaffService.Domain.Services.ServiceBase;
using Pizza4Ps.StaffService.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Pizza4Ps.StaffService.Domain.Services
{
	public class StaffService : DomainService, IStaffService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IStaffRepository _staffRepository;

		public StaffService(IUnitOfWork unitOfWork, IStaffRepository staffRepository)
		{
			_unitOfWork = unitOfWork;
			_staffRepository = staffRepository;
		}

		public async Task<Guid> CreateAsync(string code, string name, string phone, string email, StaffEnum.StaffType staffType, StaffEnum.StaffStatus status)
		{
			var entity = new Staff(Guid.NewGuid(), code, name, phone, email, staffType, status);
			_staffRepository.Add(entity);
			await _unitOfWork.SaveChangeAsync();
			return entity.Id;
		}

		public async Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false)
		{
			var entities = await _staffRepository.GetListAsTracking(x => ids.Contains(x.Id)).IgnoreQueryFilters().ToListAsync();
			if (entities == null) throw new ServerException(ServerErrorConstants.NOT_FOUND);
			foreach (var entity in entities)
			{
				if (IsHardDeleted)
				{
					_staffRepository.HardDelete(entity);
				}
				else
				{
					_staffRepository.SoftDelete(entity);
				}
			}
			await _unitOfWork.SaveChangeAsync();
		}

		public async Task RestoreAsync(List<Guid> ids)
		{
			var entities = await _staffRepository.GetListAsTracking(x => ids.Contains(x.Id)).IgnoreQueryFilters().ToListAsync();
			if (entities == null) throw new ServerException(ServerErrorConstants.NOT_FOUND);
			foreach (var entity in entities)
			{
				_staffRepository.Restore(entity);
			}
			await _unitOfWork.SaveChangeAsync();
		}

		public async Task<Guid> UpdateAsync(Guid id, string code, string name, string phone, string email, StaffEnum.StaffType staffType, StaffEnum.StaffStatus status)
		{
			var entity = await _staffRepository.GetSingleByIdAsync(id);
			entity.UpdateStaff(code, name, phone, email, staffType, status);
			await _unitOfWork.SaveChangeAsync();
			return entity.Id;
		}
	}
}
