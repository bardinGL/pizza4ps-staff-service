using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.RestoreIndividualSchedule
{
	public class RestoreIndividualScheduleCommand : IRequest
	{
		public List<Guid> Ids { get; set; }
	}
}
