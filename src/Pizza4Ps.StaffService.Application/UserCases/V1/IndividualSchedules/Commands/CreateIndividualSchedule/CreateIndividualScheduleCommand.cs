using MediatR;
using Pizza4Ps.StaffService.Application.Abstractions;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.CreateIndividualSchedule
{
    public class CreateIndividualScheduleCommand : IRequest<ResultDto<Guid>>
	{
        public DateTimeOffset SchedualDate { get; set; }
        public TimeSpan ShiftStart { get; set; }
        public TimeSpan ShiftEnd { get; set; }
        public string Status { get; set; }
        public Guid StaffId { get; set; }
    }
}
