﻿using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.RestoreHistorySchedule
{
	public class RestoreHistoryScheduleCommand : IRequest
	{
		public List<Guid> Ids { get; set; }
	}
}
