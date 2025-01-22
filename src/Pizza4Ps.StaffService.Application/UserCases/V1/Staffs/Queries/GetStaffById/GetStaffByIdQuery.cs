using MediatR;
using Pizza4Ps.StaffService.Application.DTOs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetStaffById
{
    public class GetStaffByIdQuery : IRequest<StaffDto>
	{
		public Guid Id { get; set; }
		public string IncludeProperties { get; set; } = "";
	}
}
