using Pizza4Ps.StaffService.Domain.Abstractions.Entities;

namespace Pizza4Ps.StaffService.Domain.Abstractions
{
    public abstract class EntityBase<TKey> : IEntityBase<TKey>
    {
        public TKey Id { get; set; }
    }
}
