using Pizza4Ps.StaffService.Domain.Abstractions;

namespace Pizza4Ps.StaffService.Domain.Entities
{
    public class ShiftSchedule : EntityAuditBase<Guid>
    {
        public Guid StaffId { get; set; }
        public Guid DayId { get; set; }
        public Guid ShiftId { get; set; }
        public DateTimeOffset ShiftStart { get; set; }
        public DateTimeOffset ShiftEnd { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual Day Day { get; set; }
        public virtual Shift Shift { get; set; }

        public ShiftSchedule()
        {
        }

        public ShiftSchedule(Guid id, Guid staffId, Guid dayId, Guid shiftId, DateTimeOffset shiftStart, DateTimeOffset shiftEnd)
        {
            Id = id;
            StaffId = staffId;
            DayId = dayId;
            ShiftId = shiftId;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
        }
    }
}
