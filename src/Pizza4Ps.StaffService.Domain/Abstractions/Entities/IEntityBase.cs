namespace Pizza4Ps.StaffService.Domain.Abstractions.Entities
{
    public interface IEntityBase<TKey>
    {
        TKey Id { get; }
    }
}
