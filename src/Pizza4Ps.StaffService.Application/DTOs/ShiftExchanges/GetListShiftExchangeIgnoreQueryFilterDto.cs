using Pizza4Ps.StaffService.Application.Abstractions;

namespace Pizza4Ps.StaffService.Application.DTOs.ShiftExchanges
{
	public class GetListShiftExchangeIgnoreQueryFilterDto : PaginatedRequestDto
	{
		public bool IsDeleted { get; set; } = false;
	}
}
