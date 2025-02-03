using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.UpdateIndividualSchedule
{
	public class UpdateIndividualScheduleCommandHandler : IRequestHandler<UpdateIndividualScheduleCommand>
	{
		private readonly IIndividualScheduleService _individualscheduleService;

		public UpdateIndividualScheduleCommandHandler(IIndividualScheduleService individualscheduleService)
		{
			_individualscheduleService = individualscheduleService;
		}

		public async Task Handle(UpdateIndividualScheduleCommand request, CancellationToken cancellationToken)
		{
			var result = await _individualscheduleService.UpdateAsync(
				request.Id!.Value,
				request.SchedualDate,
				request.ShiftStart,
				request.ShiftEnd,
				request.Status,
				request.StaffId);
		}
	}
}
