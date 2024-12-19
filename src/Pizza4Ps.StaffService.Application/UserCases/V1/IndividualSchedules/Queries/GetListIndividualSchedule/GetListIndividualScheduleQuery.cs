using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualSchedule
{
	public class GetListIndividualScheduleQuery : IRequest<GetListIndividualScheduleQueryResponse>
	{
		public GetListIndividualScheduleDto GetListIndividualScheduleDto { get; set; }
	}
}