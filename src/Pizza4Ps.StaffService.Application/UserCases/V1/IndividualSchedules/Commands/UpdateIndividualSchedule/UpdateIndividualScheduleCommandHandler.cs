using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.UpdateIndividualSchedule
{
	public class UpdateIndividualScheduleCommandHandler : IRequestHandler<UpdateIndividualScheduleCommand, UpdateIndividualScheduleCommandResponse>
	{
		private readonly IIndividualScheduleService _individualscheduleService;

		public UpdateIndividualScheduleCommandHandler(IIndividualScheduleService individualscheduleService)
		{
			_individualscheduleService = individualscheduleService;
		}

		public async Task<UpdateIndividualScheduleCommandResponse> Handle(UpdateIndividualScheduleCommand request, CancellationToken cancellationToken)
		{
			var result = await _individualscheduleService.UpdateAsync(
				request.Id,
				request.UpdateIndividualScheduleDto.SchedualDate,
				request.UpdateIndividualScheduleDto.ShiftStart,
				request.UpdateIndividualScheduleDto.ShiftEnd,
				request.UpdateIndividualScheduleDto.Status,
				request.UpdateIndividualScheduleDto.StaffId);
			return new UpdateIndividualScheduleCommandResponse
			{
				Id = result
			};
		}
	}
}
