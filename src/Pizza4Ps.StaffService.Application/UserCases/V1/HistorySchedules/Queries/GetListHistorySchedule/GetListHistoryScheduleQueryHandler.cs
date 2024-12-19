using System.Linq.Dynamic.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Constants;
using Pizza4Ps.StaffService.Domain.Exceptions;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistorySchedule
{
	public class GetListHistoryScheduleQueryHandler : IRequestHandler<GetListHistoryScheduleQuery, GetListHistoryScheduleQueryResponse>
	{
		private readonly IMapper _mapper;
		private readonly IHistoryScheduleRepository _historyscheduleRepository;

		public GetListHistoryScheduleQueryHandler(IMapper mapper, IHistoryScheduleRepository historyscheduleRepository)
		{
			_mapper = mapper;
			_historyscheduleRepository = historyscheduleRepository;
		}

		public async Task<GetListHistoryScheduleQueryResponse> Handle(GetListHistoryScheduleQuery request, CancellationToken cancellationToken)
		{
			var query = _historyscheduleRepository.GetListAsNoTracking(
				x => (request.GetListHistoryScheduleDto.SchedualDate == null || x.SchedualDate == request.GetListHistoryScheduleDto.SchedualDate)
				&& (request.GetListHistoryScheduleDto.ShiftStart == null || x.ShiftStart == request.GetListHistoryScheduleDto.ShiftStart)
				&& (request.GetListHistoryScheduleDto.ShiftEnd == null || x.ShiftEnd == request.GetListHistoryScheduleDto.ShiftEnd)
				&& (request.GetListHistoryScheduleDto.Status == null || x.Status.Contains(request.GetListHistoryScheduleDto.Status))
				&& (request.GetListHistoryScheduleDto.StaffId == null || x.StaffId == request.GetListHistoryScheduleDto.StaffId),
				includeProperties: request.GetListHistoryScheduleDto.includeProperties);
			var entities = await query
				.OrderBy(request.GetListHistoryScheduleDto.SortBy)
				.Skip(request.GetListHistoryScheduleDto.SkipCount).Take(request.GetListHistoryScheduleDto.TakeCount).ToListAsync();
			if (!entities.Any())
				throw new BusinessException(BussinessErrorConstants.HistoryScheduleErrorConstant.HISTORY_SCHEDULE_NOT_FOUND);
			var result = _mapper.Map<List<HistoryScheduleDto>>(entities);
			var totalCount = await query.CountAsync();
			return new GetListHistoryScheduleQueryResponse(result, totalCount);
		}
	}
}
