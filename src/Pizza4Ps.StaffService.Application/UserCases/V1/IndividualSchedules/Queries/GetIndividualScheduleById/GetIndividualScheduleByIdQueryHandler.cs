using AutoMapper;
using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetIndividualScheduleById
{
	public class GetIndividualScheduleByIdQueryHandler : IRequestHandler<GetIndividualScheduleByIdQuery, GetIndividualScheduleByIdQueryResponse>
	{
		private readonly IMapper _mapper;
		private readonly IIndividualScheduleRepository _individualscheduleRepository;

		public GetIndividualScheduleByIdQueryHandler(IMapper mapper, IIndividualScheduleRepository individualscheduleRepository)
		{
			_mapper = mapper;
			_individualscheduleRepository = individualscheduleRepository;
		}

		public async Task<GetIndividualScheduleByIdQueryResponse> Handle(GetIndividualScheduleByIdQuery request, CancellationToken cancellationToken)
		{
			var entity = await _individualscheduleRepository.GetSingleByIdAsync(request.Id, request.includeProperties);
			var result = _mapper.Map<IndividualScheduleDto>(entity);
			return new GetIndividualScheduleByIdQueryResponse
			{
				IndividualSchedule = result
			};
		}
	}
}
