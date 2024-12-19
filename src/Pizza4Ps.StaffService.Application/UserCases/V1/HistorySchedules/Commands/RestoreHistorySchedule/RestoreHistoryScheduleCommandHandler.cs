using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.RestoreHistorySchedule
{
	public class RestoreHistoryScheduleCommandHandler : IRequestHandler<RestoreHistoryScheduleCommand>
	{
		private readonly IHistoryScheduleService _historyscheduleService;

		public RestoreHistoryScheduleCommandHandler(IHistoryScheduleService historyscheduleService)
		{
			_historyscheduleService = historyscheduleService;
		}

		public async Task Handle(RestoreHistoryScheduleCommand request, CancellationToken cancellationToken)
		{
			await _historyscheduleService.RestoreAsync(request.Ids);
		}
	}
}
