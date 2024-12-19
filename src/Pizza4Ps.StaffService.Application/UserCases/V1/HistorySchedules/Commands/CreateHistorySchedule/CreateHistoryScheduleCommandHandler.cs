using AutoMapper;
using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.CreateHistorySchedule
{
	public class CreateHistoryScheduleCommandHandler : IRequestHandler<CreateHistoryScheduleCommand, CreateHistoryScheduleCommandResponse>
	{
		private readonly IMapper _mapper;
		private readonly IHistoryScheduleService _historyscheduleService;

		public CreateHistoryScheduleCommandHandler(IMapper mapper, IHistoryScheduleService historyscheduleService)
		{
			_mapper = mapper;
			_historyscheduleService = historyscheduleService;
		}

		public async Task<CreateHistoryScheduleCommandResponse> Handle(CreateHistoryScheduleCommand request, CancellationToken cancellationToken)
		{
			var result = await _historyscheduleService.CreateAsync(
				request.CreateHistoryScheduleDto.SchedualDate,
				request.CreateHistoryScheduleDto.ShiftStart,
				request.CreateHistoryScheduleDto.ShiftEnd,
				request.CreateHistoryScheduleDto.Status,
				request.CreateHistoryScheduleDto.StaffId);
			return new CreateHistoryScheduleCommandResponse
			{
				Id = result
			};
		}
	}
}
