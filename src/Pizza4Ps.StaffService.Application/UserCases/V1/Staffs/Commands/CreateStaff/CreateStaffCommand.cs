using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.Staffs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Commands.CreateStaff
{
	public class CreateStaffCommand : IRequest<CreateStaffCommandResponse>
	{
		public CreateStaffDto CreateStaffDto { get; set; }
	}
}
