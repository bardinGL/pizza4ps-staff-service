using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.Staffs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetListStaffIgnoreQueryFilter
{
	public class GetListStaffIgnoreQueryFilterQuery : IRequest<GetListStaffIgnoreQueryFilterQueryResponse>
	{
		public GetListStaffIgnoreQueryFilterDto GetListStaffIgnoreQueryFilterDto { get; set; }
	}
}
