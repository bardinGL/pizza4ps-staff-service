using AutoMapper;
using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.CreateIndividualSchedule
{
	public class CreateIndividualScheduleCommandHandler : IRequestHandler<CreateIndividualScheduleCommand, CreateIndividualScheduleCommandResponse>
	{
		private readonly IMapper _mapper;
		private readonly IIndividualScheduleService _individualscheduleService;

		public CreateIndividualScheduleCommandHandler(IMapper mapper, IIndividualScheduleService individualscheduleService)
		{
			_mapper = mapper;
			_individualscheduleService = individualscheduleService;
		}

		public async Task<CreateIndividualScheduleCommandResponse> Handle(CreateIndividualScheduleCommand request, CancellationToken cancellationToken)
		{
			var result = await _individualscheduleService.CreateAsync(
				request.CreateIndividualScheduleDto.SchedualDate,
				request.CreateIndividualScheduleDto.ShiftStart,
				request.CreateIndividualScheduleDto.ShiftEnd,
				request.CreateIndividualScheduleDto.Status,
				request.CreateIndividualScheduleDto.StaffId);
			return new CreateIndividualScheduleCommandResponse
			{
				Id = result
			};
		}
	}
}
