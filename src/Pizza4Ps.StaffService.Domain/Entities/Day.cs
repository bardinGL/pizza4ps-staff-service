using Pizza4Ps.StaffService.Domain.Abstractions;

namespace Pizza4Ps.StaffService.Domain.Entities
{
    public class Day : EntityAuditBase<Guid>
    {
        public string Name { get; set; }
    }
}
