using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Commands.DeleteStaff
{
	public class DeleteStaffCommand : IRequest
	{
		public List<Guid> Ids { get; set; }
		public bool isHardDelete { get; set; }
	}
}
