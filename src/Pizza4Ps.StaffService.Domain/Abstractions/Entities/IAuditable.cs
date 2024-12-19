namespace Pizza4Ps.StaffService.Domain.Abstractions.Entities
{
    public interface IAuditable : IDateTracking, IUserTracking, ISoftDelete
    {
    }
}
