using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualScheduleIgnoreQueryFilter
{
	public class GetListIndividualScheduleIgnoreQueryFilterQuery : IRequest<GetListIndividualScheduleIgnoreQueryFilterQueryResponse>
	{
		public GetListIndividualScheduleIgnoreQueryFilterDto GetListIndividualScheduleIgnoreQueryFilterDto { get; set; }
	}
}
