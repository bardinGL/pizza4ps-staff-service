using AutoMapper;
using MediatR;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetHistoryScheduleById
{
	public class GetHistoryScheduleByIdQueryHandler : IRequestHandler<GetHistoryScheduleByIdQuery, GetHistoryScheduleByIdQueryResponse>
	{
		private readonly IMapper _mapper;
		private readonly IHistoryScheduleRepository _historyscheduleRepository;

		public GetHistoryScheduleByIdQueryHandler(IMapper mapper, IHistoryScheduleRepository historyscheduleRepository)
		{
			_mapper = mapper;
			_historyscheduleRepository = historyscheduleRepository;
		}

		public async Task<GetHistoryScheduleByIdQueryResponse> Handle(GetHistoryScheduleByIdQuery request, CancellationToken cancellationToken)
		{
			var entity = await _historyscheduleRepository.GetSingleByIdAsync(request.Id, request.includeProperties);
			var result = _mapper.Map<HistoryScheduleDto>(entity);
			return new GetHistoryScheduleByIdQueryResponse
			{
				HistorySchedule = result
			};
		}
	}
}
