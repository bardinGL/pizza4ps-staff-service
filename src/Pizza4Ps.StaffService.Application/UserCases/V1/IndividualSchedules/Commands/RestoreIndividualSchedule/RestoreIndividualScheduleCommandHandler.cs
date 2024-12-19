using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.RestoreIndividualSchedule
{
	public class RestoreIndividualScheduleCommandHandler : IRequestHandler<RestoreIndividualScheduleCommand>
	{
		private readonly IIndividualScheduleService _individualscheduleService;

		public RestoreIndividualScheduleCommandHandler(IIndividualScheduleService individualscheduleService)
		{
			_individualscheduleService = individualscheduleService;
		}

		public async Task Handle(RestoreIndividualScheduleCommand request, CancellationToken cancellationToken)
		{
			await _individualscheduleService.RestoreAsync(request.Ids);
		}
	}
}
