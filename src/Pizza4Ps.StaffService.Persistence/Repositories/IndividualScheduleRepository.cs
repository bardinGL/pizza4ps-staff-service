using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
	public class IndividualScheduleRepository : RepositoryBase<IndividualSchedule, Guid>, IIndividualScheduleRepository
	{
		public IndividualScheduleRepository(ApplicationDBContext dBContext) : base(dBContext)
		{
		}
	}
}
