using AutoMapper;
using Pizza4Ps.StaffService.Application.DTOs.Staffs;
using Pizza4Ps.StaffService.Domain.Entities;

namespace Pizza4Ps.StaffService.Application.Mappers
{
	public class StaffProfile : Profile
	{
		public StaffProfile()
		{
			CreateMap<StaffDto, Staff>().ReverseMap();
		}
	}
}
