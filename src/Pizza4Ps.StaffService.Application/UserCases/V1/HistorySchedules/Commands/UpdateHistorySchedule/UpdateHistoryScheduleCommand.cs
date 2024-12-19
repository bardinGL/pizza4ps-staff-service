using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.UpdateHistorySchedule
{
	public class UpdateHistoryScheduleCommand : IRequest<UpdateHistoryScheduleCommandResponse>
	{
		public Guid Id { get; set; }
		public UpdateHistoryScheduleDto UpdateHistoryScheduleDto { get; set; }
	}
}
