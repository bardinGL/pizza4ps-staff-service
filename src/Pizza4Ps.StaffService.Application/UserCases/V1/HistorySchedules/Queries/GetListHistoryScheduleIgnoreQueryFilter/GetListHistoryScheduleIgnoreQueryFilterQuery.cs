using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistoryScheduleIgnoreQueryFilter
{
	public class GetListHistoryScheduleIgnoreQueryFilterQuery : IRequest<GetListHistoryScheduleIgnoreQueryFilterQueryResponse>
	{
		public GetListHistoryScheduleIgnoreQueryFilterDto GetListHistoryScheduleIgnoreQueryFilterDto { get; set; }
	}
}
