namespace Pizza4Ps.StaffService.Application.DTOs.HistorySchedules
{
	public class CreateHistoryScheduleDto
	{
		public DateTimeOffset SchedualDate { get; set; }
		public TimeSpan ShiftStart { get; set; }
		public TimeSpan ShiftEnd { get; set; }
		public string Status { get; set; }
		public Guid StaffId { get; set; }
	}
}
