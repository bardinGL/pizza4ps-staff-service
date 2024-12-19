namespace Pizza4Ps.StaffService.Domain.Abstractions.Entities
{
    public interface IUserTracking
    {
        string? CreatedBy { get; set; }
        string? ModifiedBy { get; set; }
    }
}
