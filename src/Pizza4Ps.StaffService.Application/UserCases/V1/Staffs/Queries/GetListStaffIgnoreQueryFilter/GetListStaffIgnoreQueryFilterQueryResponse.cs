using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs.Staffs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetListStaffIgnoreQueryFilter
{
	public class GetListStaffIgnoreQueryFilterQueryResponse : PaginatedResultDto<StaffDto>
	{
		public GetListStaffIgnoreQueryFilterQueryResponse(List<StaffDto> items, long totalCount) : base(items, totalCount)
		{
		}
	}
}
