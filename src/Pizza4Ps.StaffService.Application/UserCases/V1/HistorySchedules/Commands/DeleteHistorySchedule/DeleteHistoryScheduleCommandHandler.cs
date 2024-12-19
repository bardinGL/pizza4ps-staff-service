using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.PizzaService.Application.UserCases.V1.HistorySchedules.Commands.DeleteHistorySchedule
{
	public class DeleteHistoryScheduleCommandHandler : IRequestHandler<DeleteHistoryScheduleCommand>
	{
		private readonly IHistoryScheduleService _historyscheduleService;

		public DeleteHistoryScheduleCommandHandler(IHistoryScheduleService historyscheduleservice)
		{
			_historyscheduleService = historyscheduleservice;
		}

		public async Task Handle(DeleteHistoryScheduleCommand request, CancellationToken cancellationToken)
		{
			await _historyscheduleService.DeleteAsync(request.Ids, request.isHardDelete);
		}
	}
}
