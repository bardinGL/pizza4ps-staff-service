using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.CreateIndividualSchedule
{
	public class CreateIndividualScheduleCommand : IRequest<CreateIndividualScheduleCommandResponse>
	{
		public CreateIndividualScheduleDto CreateIndividualScheduleDto { get; set; }
	}
}
