using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
	public class ShiftExchangeRepository : RepositoryBase<ShiftExchange, Guid>, IShiftExchangeRepository
	{
		public ShiftExchangeRepository(ApplicationDBContext dBContext) : base(dBContext)
		{
		}
	}
}
