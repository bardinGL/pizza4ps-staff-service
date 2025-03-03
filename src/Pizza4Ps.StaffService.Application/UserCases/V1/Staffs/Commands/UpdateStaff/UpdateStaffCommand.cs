using MediatR;
using Pizza4Ps.StaffService.Domain.Enums;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Commands.UpdateStaff
{
    public class UpdateStaffCommand : IRequest
	{
		public Guid? Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public StaffTypeEnum Type { get; set; }
        public Guid RoleId { get; set; }
    }
}
