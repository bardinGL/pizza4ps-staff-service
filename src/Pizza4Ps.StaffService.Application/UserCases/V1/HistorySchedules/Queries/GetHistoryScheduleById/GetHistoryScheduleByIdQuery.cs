using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetHistoryScheduleById
{
	public class GetHistoryScheduleByIdQuery : IRequest<GetHistoryScheduleByIdQueryResponse>
	{
		public Guid Id { get; set; }
		public string includeProperties { get; set; } = "";
	}
}
