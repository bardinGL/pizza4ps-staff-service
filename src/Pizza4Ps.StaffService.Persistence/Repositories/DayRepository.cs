using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
    public class DayRepository : RepositoryBase<Day, Guid>, IDayRepository
    {
        public DayRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
        }
    }
}
