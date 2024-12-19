using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.UpdateIndividualSchedule
{
	public class UpdateIndividualScheduleCommand : IRequest<UpdateIndividualScheduleCommandResponse>
	{
		public Guid Id { get; set; }
		public UpdateIndividualScheduleDto UpdateIndividualScheduleDto { get; set; }
	}
}
