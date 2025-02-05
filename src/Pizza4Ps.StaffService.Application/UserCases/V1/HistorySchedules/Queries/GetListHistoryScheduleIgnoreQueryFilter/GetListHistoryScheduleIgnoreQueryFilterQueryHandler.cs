using System.Linq.Dynamic.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistoryScheduleIgnoreQueryFilter
{
    public class GetListHistoryScheduleIgnoreQueryFilterQueryHandler : IRequestHandler<GetListHistoryScheduleIgnoreQueryFilterQuery, PaginatedResultDto<HistoryScheduleDto>>
	{
		private readonly IMapper _mapper;
		private readonly IHistoryScheduleRepository _historyscheduleRepository;

		public GetListHistoryScheduleIgnoreQueryFilterQueryHandler(IMapper mapper, IHistoryScheduleRepository historyscheduleRepository)
		{
			_mapper = mapper;
			_historyscheduleRepository = historyscheduleRepository;
		}

		public async Task<PaginatedResultDto<HistoryScheduleDto>> Handle(GetListHistoryScheduleIgnoreQueryFilterQuery request, CancellationToken cancellationToken)
		{
			var query = _historyscheduleRepository.GetListAsNoTracking(includeProperties: request.IncludeProperties).IgnoreQueryFilters()
				.Where(
					x => (request.SchedualDate == null || x.SchedualDate == request.SchedualDate)
					&& (request.ShiftStart == null || x.ShiftStart == request.ShiftStart)
					&& (request.ShiftEnd == null || x.ShiftEnd == request.ShiftEnd)
					&& (request.Status == null || x.Status.Contains(request.Status))
					&& (request.StaffId == null || x.StaffId == request.StaffId)
					&& x.IsDeleted == request.IsDeleted);
			var entities = await query
				.OrderBy(request.SortBy)
				.Skip(request.SkipCount).Take(request.TakeCount).ToListAsync();
			var result = _mapper.Map<List<HistoryScheduleDto>>(entities);
			var totalCount = await query.CountAsync();
			return new PaginatedResultDto<HistoryScheduleDto>(result, totalCount);
		}
	}
}
