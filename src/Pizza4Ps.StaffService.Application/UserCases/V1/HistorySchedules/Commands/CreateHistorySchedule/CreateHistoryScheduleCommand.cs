using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.CreateHistorySchedule
{
	public class CreateHistoryScheduleCommand : IRequest<CreateHistoryScheduleCommandResponse>
	{
		public CreateHistoryScheduleDto CreateHistoryScheduleDto { get; set; }
	}
}
