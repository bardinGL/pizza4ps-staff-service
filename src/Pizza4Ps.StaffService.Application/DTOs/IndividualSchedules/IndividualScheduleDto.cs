﻿using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules
{
	public class IndividualScheduleDto
	{
		public Guid Id { get; set; }
		public DateTimeOffset SchedualDate { get; set; }
		public TimeSpan ShiftStart { get; set; }
		public TimeSpan ShiftEnd { get; set; }
		public string Status { get; set; }
		public Guid StaffId { get; set; }

		public virtual Staff Staff { get; set; }
	}
}
