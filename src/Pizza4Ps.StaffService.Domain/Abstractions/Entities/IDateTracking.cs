namespace Pizza4Ps.StaffService.Domain.Abstractions.Entities
{
    public interface IDateTracking
    {
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset? ModifiedDate { get; set; }
    }
}
