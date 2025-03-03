using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
    public class ShiftRepository : RepositoryBase<Shift, Guid>, IShiftRepository
    {
        public ShiftRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
        }
    }
}
