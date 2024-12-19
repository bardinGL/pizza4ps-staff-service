using Pizza4Ps.StaffService.Application.Abstractions;

namespace Pizza4Ps.StaffService.Application.DTOs.Stores
{
	public class GetListStoreIgnoreQueryFilterDto : PaginatedRequestDto
	{
		public bool IsDeleted { get; set; } = false;
	}
}
