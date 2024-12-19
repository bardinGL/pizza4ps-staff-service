using Pizza4Ps.StaffService.Application.Abstractions;

namespace Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules
{
	public class GetListIndividualScheduleDto : PaginatedRequestDto
	{
		public DateTimeOffset? SchedualDate { get; set; }
		public TimeSpan? ShiftStart { get; set; }
		public TimeSpan? ShiftEnd { get; set; }
		public string? Status { get; set; }
		public Guid? StaffId { get; set; }
	}
}
