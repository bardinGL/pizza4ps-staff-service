using MediatR;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistoryScheduleIgnoreQueryFilter
{
    public class GetListHistoryScheduleIgnoreQueryFilterQuery : PaginatedQuery<PaginatedResultDto<HistoryScheduleDto>>
    {
        public bool IsDeleted { get; set; } = false;
        public DateTimeOffset? SchedualDate { get; set; }
        public TimeSpan? ShiftStart { get; set; }
        public TimeSpan? ShiftEnd { get; set; }
        public string? Status { get; set; }
        public Guid? StaffId { get; set; }
    }
}
