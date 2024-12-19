﻿using Pizza4Ps.StaffService.Domain.Abstractions.Repositories.RepositoryBase;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Domain.Abstractions.Repositories
{
	public interface IIndividualScheduleRepository : IRepositoryBase<IndividualSchedule, Guid>
	{
	}
}
