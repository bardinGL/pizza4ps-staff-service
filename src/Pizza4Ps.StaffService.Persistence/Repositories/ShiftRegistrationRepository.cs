using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
    public class ShiftRegistrationRepository : RepositoryBase<ShiftRegistration, Guid>, IShiftRegistrationRepository
    {
        public ShiftRegistrationRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
        }
    }
}
