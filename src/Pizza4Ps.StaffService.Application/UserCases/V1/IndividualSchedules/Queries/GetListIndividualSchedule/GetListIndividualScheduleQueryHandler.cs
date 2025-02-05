using System.Linq.Dynamic.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Constants;
using Pizza4Ps.StaffService.Domain.Exceptions;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualSchedule
{
    public class GetListIndividualScheduleQueryHandler : IRequestHandler<GetListIndividualScheduleQuery, PaginatedResultDto<IndividualScheduleDto>>
	{
		private readonly IMapper _mapper;
		private readonly IIndividualScheduleRepository _individualscheduleRepository;

		public GetListIndividualScheduleQueryHandler(IMapper mapper, IIndividualScheduleRepository individualscheduleRepository)
		{
			_mapper = mapper;
			_individualscheduleRepository = individualscheduleRepository;
		}

		public async Task<PaginatedResultDto<IndividualScheduleDto>> Handle(GetListIndividualScheduleQuery request, CancellationToken cancellationToken)
		{
			var query = _individualscheduleRepository.GetListAsNoTracking(
				x => (request.SchedualDate == null || x.SchedualDate == request.SchedualDate)
				&& (request.ShiftStart == null || x.ShiftStart == request.ShiftStart)
				&& (request.ShiftEnd == null || x.ShiftEnd == request.ShiftEnd)
				&& (request.Status == null || x.Status.Contains(request.Status))
				&& (request.StaffId == null || x.StaffId == request.StaffId),
				includeProperties: request.IncludeProperties);
			var entities = await query
				.OrderBy(request.SortBy)
				.Skip(request.SkipCount).Take(request.TakeCount).ToListAsync();
			if (!entities.Any())
				throw new BusinessException(BussinessErrorConstants.IndividualScheduleErrorConstant.INDIVIDUAL_SCHEDULE_NOT_FOUND);
			var result = _mapper.Map<List<IndividualScheduleDto>>(entities);
			var totalCount = await query.CountAsync();
			return new PaginatedResultDto<IndividualScheduleDto>(result, totalCount);
		}
	}
}
