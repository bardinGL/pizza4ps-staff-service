using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.Staffs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Commands.UpdateStaff
{
	public class UpdateStaffCommand : IRequest<UpdateStaffCommandResponse>
	{
		public Guid Id { get; set; }
		public UpdateStaffDto UpdateStaffDto { get; set; }
	}
}
