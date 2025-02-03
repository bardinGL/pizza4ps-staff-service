using AutoMapper;
using MediatR;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetIndividualScheduleById
{
    public class GetIndividualScheduleByIdQueryHandler : IRequestHandler<GetIndividualScheduleByIdQuery, IndividualScheduleDto>
	{
		private readonly IMapper _mapper;
		private readonly IIndividualScheduleRepository _individualscheduleRepository;

		public GetIndividualScheduleByIdQueryHandler(IMapper mapper, IIndividualScheduleRepository individualscheduleRepository)
		{
			_mapper = mapper;
			_individualscheduleRepository = individualscheduleRepository;
		}

		public async Task<IndividualScheduleDto> Handle(GetIndividualScheduleByIdQuery request, CancellationToken cancellationToken)
		{
			var entity = await _individualscheduleRepository.GetSingleByIdAsync(request.Id, request.IncludeProperties);
			var result = _mapper.Map<IndividualScheduleDto>(entity);
			return result;
		}
	}
}
