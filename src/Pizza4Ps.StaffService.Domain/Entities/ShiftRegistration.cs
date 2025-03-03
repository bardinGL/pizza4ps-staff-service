using Pizza4Ps.StaffService.Domain.Abstractions;
using Pizza4Ps.StaffService.Domain.Enums;

namespace Pizza4Ps.StaffService.Domain.Entities
{
    public class ShiftRegistration : EntityAuditBase<Guid>
    {
        public ShiftRegistrationEnum Status { get; set; }
        public Guid StaffId { get; set; }
        public Guid DayId { get; set; }
        public Guid ShiftId { get; set; }
        public Guid RoleId { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual Day Day { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Role Role { get; set; }

        public ShiftRegistration()
        {
        }

        public ShiftRegistration(Guid id, ShiftRegistrationEnum status, Guid staffId, Guid dayId, Guid shiftId, Guid roleId)
        {
            Id = id;
            Status = status;
            StaffId = staffId;
            DayId = dayId;
            ShiftId = shiftId;
            RoleId = roleId;
        }

        public void UpdateShiftRegistration(ShiftRegistrationEnum status, Guid staffId, Guid dayId, Guid shiftId, Guid roleId)
        {
            Status = status;
            StaffId = staffId;
            DayId = dayId;
            ShiftId = shiftId;
            RoleId = roleId;
        }
    }
}
