using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualScheduleIgnoreQueryFilter
{
	public class GetListIndividualScheduleIgnoreQueryFilterQueryResponse : PaginatedResultDto<IndividualScheduleDto>
	{
		public GetListIndividualScheduleIgnoreQueryFilterQueryResponse(List<IndividualScheduleDto> items, long totalCount) : base(items, totalCount)
		{
		}
	}
}