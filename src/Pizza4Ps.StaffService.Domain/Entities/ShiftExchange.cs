using Pizza4Ps.StaffService.Domain.Abstractions;

namespace Pizza4Ps.StaffService.Domain.Entities
{
	public class ShiftExchange : EntityAuditBase<Guid>
	{
		public string Code { get; set; }
	}
}
