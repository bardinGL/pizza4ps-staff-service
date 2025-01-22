using AutoMapper;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Application.Mappers
{
    public class StoreProfile : Profile
	{
		public StoreProfile()
		{
			CreateMap<StoreDto, Store>().ReverseMap();
		}
	}
}
