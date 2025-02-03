using System.Linq.Dynamic.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualScheduleIgnoreQueryFilter
{
    public class GetListIndividualScheduleIgnoreQueryFilterQueryHandler : IRequestHandler<GetListIndividualScheduleIgnoreQueryFilterQuery, PaginatedResultDto<IndividualScheduleDto>>
	{
		private readonly IMapper _mapper;
		private readonly IIndividualScheduleRepository _individualscheduleRepository;

		public GetListIndividualScheduleIgnoreQueryFilterQueryHandler(IMapper mapper, IIndividualScheduleRepository individualscheduleRepository)
		{
			_mapper = mapper;
			_individualscheduleRepository = individualscheduleRepository;
		}

		public async Task<PaginatedResultDto<IndividualScheduleDto>> Handle(GetListIndividualScheduleIgnoreQueryFilterQuery request, CancellationToken cancellationToken)
		{
			var query = _individualscheduleRepository.GetListAsNoTracking(includeProperties: request.IncludeProperties).IgnoreQueryFilters()
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
			var result = _mapper.Map<List<IndividualScheduleDto>>(entities);
			var totalCount = await query.CountAsync();
			return new PaginatedResultDto<IndividualScheduleDto>(result, totalCount);
		}
	}
}
