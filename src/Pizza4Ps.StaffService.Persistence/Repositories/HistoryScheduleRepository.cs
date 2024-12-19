using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
	public class HistoryScheduleRepository : RepositoryBase<HistorySchedule, Guid>, IHistoryScheduleRepository
	{
		public HistoryScheduleRepository(ApplicationDBContext dBContext) : base(dBContext)
		{
		}
	}
}
