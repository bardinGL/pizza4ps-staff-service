using System.Linq.Dynamic.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualScheduleIgnoreQueryFilter
{
	public class GetListIndividualScheduleIgnoreQueryFilterQueryHandler : IRequestHandler<GetListIndividualScheduleIgnoreQueryFilterQuery, GetListIndividualScheduleIgnoreQueryFilterQueryResponse>
	{
		private readonly IMapper _mapper;
		private readonly IIndividualScheduleRepository _individualscheduleRepository;

		public GetListIndividualScheduleIgnoreQueryFilterQueryHandler(IMapper mapper, IIndividualScheduleRepository individualscheduleRepository)
		{
			_mapper = mapper;
			_individualscheduleRepository = individualscheduleRepository;
		}

		public async Task<GetListIndividualScheduleIgnoreQueryFilterQueryResponse> Handle(GetListIndividualScheduleIgnoreQueryFilterQuery request, CancellationToken cancellationToken)
		{
			var query = _individualscheduleRepository.GetListAsNoTracking(includeProperties: request.GetListIndividualScheduleIgnoreQueryFilterDto.includeProperties).IgnoreQueryFilters()
				.Where(
					x => (request.GetListIndividualScheduleIgnoreQueryFilterDto.SchedualDate == null || x.SchedualDate == request.GetListIndividualScheduleIgnoreQueryFilterDto.SchedualDate)
					&& (request.GetListIndividualScheduleIgnoreQueryFilterDto.ShiftStart == null || x.ShiftStart == request.GetListIndividualScheduleIgnoreQueryFilterDto.ShiftStart)
					&& (request.GetListIndividualScheduleIgnoreQueryFilterDto.ShiftEnd == null || x.ShiftEnd == request.GetListIndividualScheduleIgnoreQueryFilterDto.ShiftEnd)
					&& (request.GetListIndividualScheduleIgnoreQueryFilterDto.Status == null || x.Status.Contains(request.GetListIndividualScheduleIgnoreQueryFilterDto.Status))
					&& (request.GetListIndividualScheduleIgnoreQueryFilterDto.StaffId == null || x.StaffId == request.GetListIndividualScheduleIgnoreQueryFilterDto.StaffId)
					&& x.IsDeleted == request.GetListIndividualScheduleIgnoreQueryFilterDto.IsDeleted);
			var entities = await query
				.OrderBy(request.GetListIndividualScheduleIgnoreQueryFilterDto.SortBy)
				.Skip(request.GetListIndividualScheduleIgnoreQueryFilterDto.SkipCount).Take(request.GetListIndividualScheduleIgnoreQueryFilterDto.TakeCount).ToListAsync();
			var result = _mapper.Map<List<IndividualScheduleDto>>(entities);
			var totalCount = await query.CountAsync();
			return new GetListIndividualScheduleIgnoreQueryFilterQueryResponse(result, totalCount);
		}
	}
}
