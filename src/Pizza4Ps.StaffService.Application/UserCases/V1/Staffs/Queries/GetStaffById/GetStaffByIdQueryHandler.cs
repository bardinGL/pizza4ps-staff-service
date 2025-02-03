using AutoMapper;
using MediatR;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetStaffById
{
    public class GetStaffByIdQueryHandler : IRequestHandler<GetStaffByIdQuery, StaffDto>
	{
		private readonly IMapper _mapper;
		private readonly IStaffRepository _staffRepository;

		public GetStaffByIdQueryHandler(IMapper mapper, IStaffRepository staffRepository)
		{
			_mapper = mapper;
			_staffRepository = staffRepository;
		}

		public async Task<StaffDto> Handle(GetStaffByIdQuery request, CancellationToken cancellationToken)
		{
			var entity = await _staffRepository.GetSingleByIdAsync(request.Id, request.IncludeProperties);
			var result = _mapper.Map<StaffDto>(entity);
			return result;
		}
	}
}
