using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.UpdateHistorySchedule
{
	public class UpdateHistoryScheduleCommandHandler : IRequestHandler<UpdateHistoryScheduleCommand>
	{
		private readonly IHistoryScheduleService _historyscheduleService;

		public UpdateHistoryScheduleCommandHandler(IHistoryScheduleService historyscheduleService)
		{
			_historyscheduleService = historyscheduleService;
		}

		public async Task Handle(UpdateHistoryScheduleCommand request, CancellationToken cancellationToken)
		{
			var result = await _historyscheduleService.UpdateAsync(
				request.Id!.Value,
				request.SchedualDate,
				request.ShiftStart,
				request.ShiftEnd,
				request.Status,
				request.StaffId);
		}
	}
}
