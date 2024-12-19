using System.Linq.Dynamic.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Constants;
using Pizza4Ps.StaffService.Domain.Exceptions;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualSchedule
{
	public class GetListIndividualScheduleQueryHandler : IRequestHandler<GetListIndividualScheduleQuery, GetListIndividualScheduleQueryResponse>
	{
		private readonly IMapper _mapper;
		private readonly IIndividualScheduleRepository _individualscheduleRepository;

		public GetListIndividualScheduleQueryHandler(IMapper mapper, IIndividualScheduleRepository individualscheduleRepository)
		{
			_mapper = mapper;
			_individualscheduleRepository = individualscheduleRepository;
		}

		public async Task<GetListIndividualScheduleQueryResponse> Handle(GetListIndividualScheduleQuery request, CancellationToken cancellationToken)
		{
			var query = _individualscheduleRepository.GetListAsNoTracking(
				x => (request.GetListIndividualScheduleDto.SchedualDate == null || x.SchedualDate == request.GetListIndividualScheduleDto.SchedualDate)
				&& (request.GetListIndividualScheduleDto.ShiftStart == null || x.ShiftStart == request.GetListIndividualScheduleDto.ShiftStart)
				&& (request.GetListIndividualScheduleDto.ShiftEnd == null || x.ShiftEnd == request.GetListIndividualScheduleDto.ShiftEnd)
				&& (request.GetListIndividualScheduleDto.Status == null || x.Status.Contains(request.GetListIndividualScheduleDto.Status))
				&& (request.GetListIndividualScheduleDto.StaffId == null || x.StaffId == request.GetListIndividualScheduleDto.StaffId),
				includeProperties: request.GetListIndividualScheduleDto.includeProperties);
			var entities = await query
				.OrderBy(request.GetListIndividualScheduleDto.SortBy)
				.Skip(request.GetListIndividualScheduleDto.SkipCount).Take(request.GetListIndividualScheduleDto.TakeCount).ToListAsync();
			if (!entities.Any())
				throw new BusinessException(BussinessErrorConstants.IndividualScheduleErrorConstant.INDIVIDUAL_SCHEDULE_NOT_FOUND);
			var result = _mapper.Map<List<IndividualScheduleDto>>(entities);
			var totalCount = await query.CountAsync();
			return new GetListIndividualScheduleQueryResponse(result, totalCount);
		}
	}
}
