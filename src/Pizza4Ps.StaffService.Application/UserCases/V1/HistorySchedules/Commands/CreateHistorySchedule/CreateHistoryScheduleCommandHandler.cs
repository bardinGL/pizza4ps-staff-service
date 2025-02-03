using AutoMapper;
using MediatR;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.CreateHistorySchedule
{
	public class CreateHistoryScheduleCommandHandler : IRequestHandler<CreateHistoryScheduleCommand, ResultDto<Guid>>
	{
		private readonly IMapper _mapper;
		private readonly IHistoryScheduleService _historyscheduleService;

		public CreateHistoryScheduleCommandHandler(IMapper mapper, IHistoryScheduleService historyscheduleService)
		{
			_mapper = mapper;
			_historyscheduleService = historyscheduleService;
		}

		public async Task<ResultDto<Guid>> Handle(CreateHistoryScheduleCommand request, CancellationToken cancellationToken)
		{
			var result = await _historyscheduleService.CreateAsync(
				request.SchedualDate,
				request.ShiftStart,
				request.ShiftEnd,
				request.Status,
				request.StaffId);
			return new ResultDto<Guid>
            {
				Id = result
			};
		}
	}
}
