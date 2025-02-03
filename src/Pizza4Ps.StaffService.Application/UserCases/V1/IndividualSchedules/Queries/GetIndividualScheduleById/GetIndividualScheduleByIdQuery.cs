using MediatR;
using Pizza4Ps.StaffService.Application.DTOs;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetIndividualScheduleById
{
    public class GetIndividualScheduleByIdQuery : IRequest<IndividualScheduleDto>
	{
		public Guid Id { get; set; }
		public string IncludeProperties { get; set; } = "";
	}
}
