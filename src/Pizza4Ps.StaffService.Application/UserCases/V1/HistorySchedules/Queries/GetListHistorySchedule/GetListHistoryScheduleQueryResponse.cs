using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistorySchedule
{
	public class GetListHistoryScheduleQueryResponse : PaginatedResultDto<HistoryScheduleDto>
	{
		public GetListHistoryScheduleQueryResponse(List<HistoryScheduleDto> items, long totalCount) : base(items, totalCount)
		{
		}
	}
}
