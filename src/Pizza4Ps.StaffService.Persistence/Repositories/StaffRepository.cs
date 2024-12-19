using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
	public class StaffRepository : RepositoryBase<Staff, Guid>, IStaffRepository
	{
		public StaffRepository(ApplicationDBContext dBContext) : base(dBContext)
		{
		}
	}
}
