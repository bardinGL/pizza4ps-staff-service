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
		public StaffEnum.StaffType StaffType { get; set; }
		public StaffEnum.StaffStatus Status { get; set; }

		public Staff()
		{
		}

		public Staff(Guid id, string code, string name, string phone, string email, StaffEnum.StaffType staffType, StaffEnum.StaffStatus status)
		{
			Id = id;
			Code = code;
			Name = name;
			Phone = phone;
			Email = email;
			StaffType = staffType;
			Status = status;
		}

		public void UpdateStaff(string code, string name, string phone, string email, StaffEnum.StaffType staffType, StaffEnum.StaffStatus status)
		{
			Code = code;
			Name = name;
			Phone = phone;
			Email = email;
			StaffType = staffType;
			Status = status;
		}
	}
}
