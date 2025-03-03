using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Persistence.Repositories
{
    public class RoleRepository : RepositoryBase<Role, Guid>, IRoleRepository
    {
        public RoleRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
        }
    }
}
