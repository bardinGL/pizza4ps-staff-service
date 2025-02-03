using AutoMapper;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Application.Mappers
{
    public class ShiftExchangeProfile : Profile
	{
		public ShiftExchangeProfile()
		{
			CreateMap<ShiftExchangeDto, ShiftExchange>().ReverseMap();
		}
	}
}
