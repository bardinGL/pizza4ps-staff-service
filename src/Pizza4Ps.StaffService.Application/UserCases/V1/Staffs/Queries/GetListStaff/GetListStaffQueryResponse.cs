using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs.Staffs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetListStaff
{
	public class GetListStaffQueryResponse : PaginatedResultDto<StaffDto>
	{
		public GetListStaffQueryResponse(List<StaffDto> items, long totalCount) : base(items, totalCount)
		{
		}
	}
}
