using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
    public class ShiftScheduleRepository : RepositoryBase<ShiftSchedule, Guid>, IShiftScheduleRepository
    {
        public ShiftScheduleRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
        }
    }
}
