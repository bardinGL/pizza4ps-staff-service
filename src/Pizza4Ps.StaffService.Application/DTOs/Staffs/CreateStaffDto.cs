using Pizza4Ps.StaffService.Domain.Enums;

namespace Pizza4Ps.StaffService.Application.DTOs.Staffs
{
	public class CreateStaffDto
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public StaffEnum.StaffType StaffType { get; set; }
		public StaffEnum.StaffStatus Status { get; set; }
	}
}
