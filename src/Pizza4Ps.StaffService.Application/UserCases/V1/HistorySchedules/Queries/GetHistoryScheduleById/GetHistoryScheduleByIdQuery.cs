using MediatR;
using Pizza4Ps.StaffService.Application.DTOs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetHistoryScheduleById
{
    public class GetHistoryScheduleByIdQuery : IRequest<HistoryScheduleDto>
	{
		public Guid Id { get; set; }
		public string IncludeProperties { get; set; } = "";
	}
}
