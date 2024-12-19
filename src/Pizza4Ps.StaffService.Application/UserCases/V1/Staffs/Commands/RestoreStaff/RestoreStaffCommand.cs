using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Commands.RestoreStaff
{
	public class RestoreStaffCommand : IRequest
	{
		public List<Guid> Ids { get; set; }
	}
}
