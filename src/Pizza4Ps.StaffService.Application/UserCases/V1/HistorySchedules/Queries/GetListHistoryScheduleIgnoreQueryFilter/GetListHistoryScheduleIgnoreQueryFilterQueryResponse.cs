using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistoryScheduleIgnoreQueryFilter
{
	public class GetListHistoryScheduleIgnoreQueryFilterQueryResponse : PaginatedResultDto<HistoryScheduleDto>
	{
		public GetListHistoryScheduleIgnoreQueryFilterQueryResponse(List<HistoryScheduleDto> items, long totalCount) : base(items, totalCount)
		{
		}
	}
}