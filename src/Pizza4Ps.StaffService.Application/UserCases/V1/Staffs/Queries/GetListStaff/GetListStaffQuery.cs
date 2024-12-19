using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.Staffs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetListStaff
{
	public class GetListStaffQuery : IRequest<GetListStaffQueryResponse>
	{
		public GetListStaffDto GetListStaffDto { get; set; }
	}
}
