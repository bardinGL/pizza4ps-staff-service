﻿using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.UpdateIndividualSchedule
{
    public class UpdateIndividualScheduleCommand : IRequest
	{
		public Guid? Id { get; set; }
        public DateTimeOffset SchedualDate { get; set; }
        public TimeSpan ShiftStart { get; set; }
        public TimeSpan ShiftEnd { get; set; }
        public string Status { get; set; }
        public Guid StaffId { get; set; }
    }
}
