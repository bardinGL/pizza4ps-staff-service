using System.Linq.Dynamic.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistoryScheduleIgnoreQueryFilter
{
	public class GetListHistoryScheduleIgnoreQueryFilterQueryHandler : IRequestHandler<GetListHistoryScheduleIgnoreQueryFilterQuery, GetListHistoryScheduleIgnoreQueryFilterQueryResponse>
	{
		private readonly IMapper _mapper;
		private readonly IHistoryScheduleRepository _historyscheduleRepository;

		public GetListHistoryScheduleIgnoreQueryFilterQueryHandler(IMapper mapper, IHistoryScheduleRepository historyscheduleRepository)
		{
			_mapper = mapper;
			_historyscheduleRepository = historyscheduleRepository;
		}

		public async Task<GetListHistoryScheduleIgnoreQueryFilterQueryResponse> Handle(GetListHistoryScheduleIgnoreQueryFilterQuery request, CancellationToken cancellationToken)
		{
			var query = _historyscheduleRepository.GetListAsNoTracking(includeProperties: request.GetListHistoryScheduleIgnoreQueryFilterDto.includeProperties).IgnoreQueryFilters()
				.Where(
					x => (request.GetListHistoryScheduleIgnoreQueryFilterDto.SchedualDate == null || x.SchedualDate == request.GetListHistoryScheduleIgnoreQueryFilterDto.SchedualDate)
					&& (request.GetListHistoryScheduleIgnoreQueryFilterDto.ShiftStart == null || x.ShiftStart == request.GetListHistoryScheduleIgnoreQueryFilterDto.ShiftStart)
					&& (request.GetListHistoryScheduleIgnoreQueryFilterDto.ShiftEnd == null || x.ShiftEnd == request.GetListHistoryScheduleIgnoreQueryFilterDto.ShiftEnd)
					&& (request.GetListHistoryScheduleIgnoreQueryFilterDto.Status == null || x.Status.Contains(request.GetListHistoryScheduleIgnoreQueryFilterDto.Status))
					&& (request.GetListHistoryScheduleIgnoreQueryFilterDto.StaffId == null || x.StaffId == request.GetListHistoryScheduleIgnoreQueryFilterDto.StaffId)
					&& x.IsDeleted == request.GetListHistoryScheduleIgnoreQueryFilterDto.IsDeleted);
			var entities = await query
				.OrderBy(request.GetListHistoryScheduleIgnoreQueryFilterDto.SortBy)
				.Skip(request.GetListHistoryScheduleIgnoreQueryFilterDto.SkipCount).Take(request.GetListHistoryScheduleIgnoreQueryFilterDto.TakeCount).ToListAsync();
			var result = _mapper.Map<List<HistoryScheduleDto>>(entities);
			var totalCount = await query.CountAsync();
			return new GetListHistoryScheduleIgnoreQueryFilterQueryResponse(result, totalCount);
		}
	}
}
