using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
	public class StoreRepository : RepositoryBase<Store, Guid>, IStoreRepository
	{
		public StoreRepository(ApplicationDBContext dBContext) : base(dBContext)
		{
		}
	}
}
