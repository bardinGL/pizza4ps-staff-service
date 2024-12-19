using MediatR;
using Pizza4Ps.StaffService.Domain.Abstractions.Services;

namespace Pizza4Ps.StaffService.Application.UserCases.V1.Staffs.Commands.RestoreStaff
{
	public class RestoreStaffCommandHandler : IRequestHandler<RestoreStaffCommand>
	{
		private readonly IStaffService _staffService;

		public RestoreStaffCommandHandler(IStaffService staffService)
		{
			_staffService = staffService;
		}

		public async Task Handle(RestoreStaffCommand request, CancellationToken cancellationToken)
		{
			await _staffService.RestoreAsync(request.Ids);
		}
	}
}
