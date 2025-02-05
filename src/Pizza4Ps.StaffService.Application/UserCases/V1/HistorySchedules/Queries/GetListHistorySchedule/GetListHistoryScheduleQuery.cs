using MediatR;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistorySchedule
{
    public class GetListHistoryScheduleQuery : PaginatedQuery<PaginatedResultDto<HistoryScheduleDto>>
    {
        public DateTimeOffset? SchedualDate { get; set; }
        public TimeSpan? ShiftStart { get; set; }
        public TimeSpan? ShiftEnd { get; set; }
        public string? Status { get; set; }
        public Guid? StaffId { get; set; }
    }
}