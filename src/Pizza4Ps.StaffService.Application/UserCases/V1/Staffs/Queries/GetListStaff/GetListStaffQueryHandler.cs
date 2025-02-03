﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Abstractions.Repositories;
using Pizza4Ps.StaffService.Domain.Constants;
using Pizza4Ps.StaffService.Domain.Exceptions;
using System.Linq.Dynamic.Core;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetListStaff
{
    public class GetListStaffQueryHandler : IRequestHandler<GetListStaffQuery, PaginatedResultDto<StaffDto>>
	{
		private readonly IMapper _mapper;
		private readonly IStaffRepository _staffRepository;

		public GetListStaffQueryHandler(IMapper mapper, IStaffRepository staffRepository)
		{
			_mapper = mapper;
			_staffRepository = staffRepository;
		}

		public async Task<PaginatedResultDto<StaffDto>> Handle(GetListStaffQuery request, CancellationToken cancellationToken)
		{
			var query = _staffRepository.GetListAsNoTracking(
				x => (request.Code == null || x.Code.Contains(request.Code))
				&& (request.Name == null || x.Name.Contains(request.Name))
				&& (request.Phone == null || x.Phone.Contains(request.Phone))
				&& (request.Email == null || x.Email.Contains(request.Email))
				&& (request.StaffType == null || x.StaffType == request.StaffType)
				&& (request.Status == null || x.Status == request.Status),
				includeProperties: request.IncludeProperties);
			var entities = await query
				.OrderBy(request.SortBy)
				.Skip(request.SkipCount).Take(request.TakeCount).ToListAsync();
			if (!entities.Any())
				throw new BusinessException(BussinessErrorConstants.StaffErrorConstant.STAFF_NOT_FOUND);
			var result = _mapper.Map<List<StaffDto>>(entities);
			var totalCount = await query.CountAsync();
			return new PaginatedResultDto<StaffDto>(result, totalCount);
		}
	}
}
