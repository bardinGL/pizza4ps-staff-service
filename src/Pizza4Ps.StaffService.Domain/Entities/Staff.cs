using Pizza4Ps.StaffService.Domain.Abstractions;
using Pizza4Ps.StaffService.Domain.Enums;

namespace Pizza4Ps.StaffService.Domain.Entities
{
    public class Staff : EntityAuditBase<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public StaffTypeEnum Type { get; set; }
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }

        public Staff()
        {
        }

        public Staff(Guid id, string code, string name, string phone, string email, StaffTypeEnum type, Guid roleId)
        {
            Id = id;
            Code = code;
            Name = name;
            Phone = phone;
            Email = email;
            Type = type;
            RoleId = roleId;
        }

        public void UpdateStaff(string code, string name, string phone, string email, StaffTypeEnum type, Guid roleId)
        {
            Code = code;
            Name = name;
            Phone = phone;
            Email = email;
            Type = type;
            RoleId = roleId;
        }
    }
}
