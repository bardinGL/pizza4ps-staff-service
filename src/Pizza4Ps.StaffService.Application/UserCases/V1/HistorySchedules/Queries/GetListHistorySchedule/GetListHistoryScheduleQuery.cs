using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistorySchedule
{
	public class GetListHistoryScheduleQuery : IRequest<GetListHistoryScheduleQueryResponse>
	{
		public GetListHistoryScheduleDto GetListHistoryScheduleDto { get; set; }
	}
}