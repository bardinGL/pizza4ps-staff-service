using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualSchedule
{
	public class GetListIndividualScheduleQueryResponse : PaginatedResultDto<IndividualScheduleDto>
	{
		public GetListIndividualScheduleQueryResponse(List<IndividualScheduleDto> items, long totalCount) : base(items, totalCount)
		{
		}
	}
}
