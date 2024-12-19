using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.DeleteIndividualSchedule
{
	public class DeleteIndividualScheduleCommand : IRequest
	{
		public List<Guid> Ids { get; set; }
		public bool isHardDelete { get; set; }
	}
}
