using MediatR;
using Pizza4Ps.StaffService.Application.Abstractions;
using Pizza4Ps.StaffService.Application.DTOs;
using Pizza4Ps.StaffService.Domain.Enums;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Queries.GetListStaff
{
    public class GetListStaffQuery : PaginatedQuery<PaginatedResultDto<StaffDto>>
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public StaffEnum.StaffType? StaffType { get; set; }
        public StaffEnum.StaffStatus? Status { get; set; }
    }
}
