using MediatR;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetIndividualScheduleById
{
	public class GetIndividualScheduleByIdQuery : IRequest<GetIndividualScheduleByIdQueryResponse>
	{
		public Guid Id { get; set; }
		public string includeProperties { get; set; } = "";
	}
}
