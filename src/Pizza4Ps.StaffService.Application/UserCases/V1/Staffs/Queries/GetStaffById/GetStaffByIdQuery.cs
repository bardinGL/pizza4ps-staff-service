using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetStaffById
{
	public class GetStaffByIdQuery : IRequest<GetStaffByIdQueryResponse>
	{
		public Guid Id { get; set; }
		public string includeProperties { get; set; } = "";
	}
}
