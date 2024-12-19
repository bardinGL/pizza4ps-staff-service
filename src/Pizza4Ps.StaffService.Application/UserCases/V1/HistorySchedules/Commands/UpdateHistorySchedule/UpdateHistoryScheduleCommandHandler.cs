using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.UpdateHistorySchedule
{
	public class UpdateHistoryScheduleCommandHandler : IRequestHandler<UpdateHistoryScheduleCommand, UpdateHistoryScheduleCommandResponse>
	{
		private readonly IHistoryScheduleService _historyscheduleService;

		public UpdateHistoryScheduleCommandHandler(IHistoryScheduleService historyscheduleService)
		{
			_historyscheduleService = historyscheduleService;
		}

		public async Task<UpdateHistoryScheduleCommandResponse> Handle(UpdateHistoryScheduleCommand request, CancellationToken cancellationToken)
		{
			var result = await _historyscheduleService.UpdateAsync(
				request.Id,
				request.UpdateHistoryScheduleDto.SchedualDate,
				request.UpdateHistoryScheduleDto.ShiftStart,
				request.UpdateHistoryScheduleDto.ShiftEnd,
				request.UpdateHistoryScheduleDto.Status,
				request.UpdateHistoryScheduleDto.StaffId);
			return new UpdateHistoryScheduleCommandResponse
			{
				Id = result
			};
		}
	}
}
