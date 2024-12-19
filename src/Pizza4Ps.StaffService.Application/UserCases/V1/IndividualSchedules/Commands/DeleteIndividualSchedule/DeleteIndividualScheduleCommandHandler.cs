using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.DeleteIndividualSchedule
{
	public class DeleteIndividualScheduleCommandHandler : IRequestHandler<DeleteIndividualScheduleCommand>
	{
		private readonly IIndividualScheduleService _individualscheduleService;

		public DeleteIndividualScheduleCommandHandler(IIndividualScheduleService individualscheduleservice)
		{
			_individualscheduleService = individualscheduleservice;
		}

		public async Task Handle(DeleteIndividualScheduleCommand request, CancellationToken cancellationToken)
		{
			await _individualscheduleService.DeleteAsync(request.Ids, request.isHardDelete);
		}
	}
}
