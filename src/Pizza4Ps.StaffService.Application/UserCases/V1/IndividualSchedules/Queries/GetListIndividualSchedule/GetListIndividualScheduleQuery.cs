using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualSchedule
{
    public class GetListIndividualScheduleQuery : PaginatedQuery<PaginatedResultDto<IndividualScheduleDto>>
    {
        public DateTimeOffset? SchedualDate { get; set; }
        public TimeSpan? ShiftStart { get; set; }
        public TimeSpan? ShiftEnd { get; set; }
        public string? Status { get; set; }
        public Guid? StaffId { get; set; }
    }
}