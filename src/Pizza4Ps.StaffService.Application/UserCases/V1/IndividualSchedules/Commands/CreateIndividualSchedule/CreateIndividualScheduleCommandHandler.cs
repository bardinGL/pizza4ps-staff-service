using AutoMapper;
using MediatR;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.CreateIndividualSchedule
{
	public class CreateIndividualScheduleCommandHandler : IRequestHandler<CreateIndividualScheduleCommand, ResultDto<Guid>>
	{
		private readonly IMapper _mapper;
		private readonly IIndividualScheduleService _individualscheduleService;

		public CreateIndividualScheduleCommandHandler(IMapper mapper, IIndividualScheduleService individualscheduleService)
		{
			_mapper = mapper;
			_individualscheduleService = individualscheduleService;
		}

		public async Task<ResultDto<Guid>> Handle(CreateIndividualScheduleCommand request, CancellationToken cancellationToken)
		{
			var result = await _individualscheduleService.CreateAsync(
				request.SchedualDate,
				request.ShiftStart,
				request.ShiftEnd,
				request.Status,
				request.StaffId);
			return new ResultDto<Guid>
            {
				Id = result
			};
		}
	}
}
