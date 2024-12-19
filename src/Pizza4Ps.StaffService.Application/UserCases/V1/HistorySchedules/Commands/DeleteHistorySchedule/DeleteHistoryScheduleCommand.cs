using MediatR;

namespace Pizza4Ps.PizzaService.Application.UserCases.V1.HistorySchedules.Commands.DeleteHistorySchedule
{
	public class DeleteHistoryScheduleCommand : IRequest
	{
		public List<Guid> Ids { get; set; }
		public bool isHardDelete { get; set; }
	}
}
