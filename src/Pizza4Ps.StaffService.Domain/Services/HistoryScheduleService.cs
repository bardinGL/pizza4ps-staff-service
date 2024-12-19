using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Abstractions;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;
using Pizza4Ps.StaffService.Domain.Services.ServiceBase;
using Pizza4Ps.StaffService.Domain.Entities;
using Pizza4Ps.StaffService.Domain.Constants;
using Pizza4Ps.StaffService.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Pizza4Ps.StaffService.Domain.Services
{
	public class HistoryScheduleService : DomainService, IHistoryScheduleService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IHistoryScheduleRepository _historyScheduleRepository;

		public HistoryScheduleService(IUnitOfWork unitOfWork, IHistoryScheduleRepository historyScheduleRepository)
		{
			_unitOfWork = unitOfWork;
			_historyScheduleRepository = historyScheduleRepository;
		}

		public async Task<Guid> CreateAsync(DateTimeOffset schedualDate, TimeSpan shiftStart, TimeSpan shiftEnd, string status, Guid staffId)
		{
			var entity = new HistorySchedule(Guid.NewGuid(), schedualDate, shiftStart, shiftEnd, status, staffId);
			_historyScheduleRepository.Add(entity);
			await _unitOfWork.SaveChangeAsync();
			return entity.Id;
		}

		public async Task DeleteAsync(List<Guid> ids, bool IsHardDeleted = false)
		{
			var entities = await _historyScheduleRepository.GetListAsTracking(x => ids.Contains(x.Id)).IgnoreQueryFilters().ToListAsync();
			if (entities == null) throw new ServerException(ServerErrorConstants.NOT_FOUND);
			foreach (var entity in entities)
			{
				if (IsHardDeleted)
				{
					_historyScheduleRepository.HardDelete(entity);
				}
				else
				{
					_historyScheduleRepository.SoftDelete(entity);
				}
			}
			await _unitOfWork.SaveChangeAsync();
		}

		public async Task RestoreAsync(List<Guid> ids)
		{
			var entities = await _historyScheduleRepository.GetListAsTracking(x => ids.Contains(x.Id)).IgnoreQueryFilters().ToListAsync();
			if (entities == null) throw new ServerException(ServerErrorConstants.NOT_FOUND);
			foreach (var entity in entities)
			{
				_historyScheduleRepository.Restore(entity);
			}
			await _unitOfWork.SaveChangeAsync();
		}

		public async Task<Guid> UpdateAsync(Guid id, DateTimeOffset schedualDate, TimeSpan shiftStart, TimeSpan shiftEnd, string status, Guid staffId)
		{
			var entity = await _historyScheduleRepository.GetSingleByIdAsync(id);
			entity.UpdateHistorySchedule(schedualDate, shiftStart, shiftEnd, status, staffId);
			await _unitOfWork.SaveChangeAsync();
			return entity.Id;
		}
	}
}
