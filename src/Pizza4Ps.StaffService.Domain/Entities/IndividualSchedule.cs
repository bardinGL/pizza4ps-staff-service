using Pizza4Ps.StaffService.Domain.Abstractions;

namespace Pizza4Ps.StaffService.Domain.Entities
{
	public class IndividualSchedule : EntityAuditBase<Guid>
	{
		public DateTimeOffset SchedualDate { get; set; }
		public TimeSpan ShiftStart { get; set; }
		public TimeSpan ShiftEnd { get; set; }
		public string Status { get; set; }
		public Guid StaffId { get; set; }

		public virtual Staff Staff { get; set; }

		public IndividualSchedule()
		{
		}

		public IndividualSchedule(Guid id, DateTimeOffset schedualDate, TimeSpan shiftStart, TimeSpan shiftEnd, string status, Guid staffId)
		{
			Id = id;
			SchedualDate = schedualDate;
			ShiftStart = shiftStart;
			ShiftEnd = shiftEnd;
			Status = status;
			StaffId = staffId;
		}

		public void UpdateIndividualSchedule(DateTimeOffset schedualDate, TimeSpan shiftStart, TimeSpan shiftEnd, string status, Guid staffId)
		{
			SchedualDate = schedualDate;
			ShiftStart = shiftStart;
			ShiftEnd = shiftEnd;
			Status = status;
			StaffId = staffId;
		}
	}
}
