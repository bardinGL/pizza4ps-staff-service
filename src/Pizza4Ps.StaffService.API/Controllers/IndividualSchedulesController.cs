using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pizza4Ps.StaffService.API.Constants;
using Pizza4Ps.StaffService.API.Models;
using Pizza4Ps.StaffService.Application.DTOs.IndividualSchedules;
using Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.CreateIndividualSchedule;
using Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.RestoreIndividualSchedule;
using Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.UpdateIndividualSchedule;
using Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualSchedule;
using Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetListIndividualScheduleIgnoreQueryFilter;
using Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Queries.GetIndividualScheduleById;
using Pizza4Ps.StaffService.Application.UserCases.V1.IndividualSchedules.Commands.DeleteIndividualSchedule;

namespace Pizza4Ps.StaffService.API.Controllers
{
	[Route("api/individual-schedules")]
	[ApiController]
	public class IndividualSchedulesController : ControllerBase
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly ISender _sender;

		public IndividualSchedulesController(ISender sender, IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
			_sender = sender;
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync([FromBody] CreateIndividualScheduleDto request)
		{
			var result = await _sender.Send(new CreateIndividualScheduleCommand { CreateIndividualScheduleDto = request });
			return Ok(new ApiResponse
			{
				Result = result,
				Message = Message.CREATED_SUCCESS,
				StatusCode = StatusCodes.Status201Created
			});
		}

		[HttpGet("ignore-filter")]
		public async Task<IActionResult> GetListIgnoreQueryFilterAsync([FromQuery] GetListIndividualScheduleIgnoreQueryFilterDto query)
		{
			var result = await _sender.Send(new GetListIndividualScheduleIgnoreQueryFilterQuery { GetListIndividualScheduleIgnoreQueryFilterDto = query });
			return Ok(new ApiResponse
			{
				Result = result,
				Message = Message.GET_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}

		[HttpGet()]
		public async Task<IActionResult> GetListAsync([FromQuery] GetListIndividualScheduleDto query)
		{
			var result = await _sender.Send(new GetListIndividualScheduleQuery { GetListIndividualScheduleDto = query });
			return Ok(new ApiResponse
			{
				Result = result,
				Message = Message.GET_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetSingleByIdAsync([FromRoute] Guid id)
		{
			var result = await _sender.Send(new GetIndividualScheduleByIdQuery { Id = id });
			return Ok(new ApiResponse
			{
				Result = result,
				Message = Message.GET_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateAsync([FromRoute] Guid id, [FromBody] UpdateIndividualScheduleDto request)
		{
			var result = await _sender.Send(new UpdateIndividualScheduleCommand { Id = id, UpdateIndividualScheduleDto = request });
			return Ok(new ApiResponse
			{
				Result = result,
				Message = Message.UPDATED_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}

		[HttpPut("restore")]
		public async Task<IActionResult> RestoreManyAsync(List<Guid> ids)
		{
			await _sender.Send(new RestoreIndividualScheduleCommand { Ids = ids });
			return Ok(new ApiResponse
			{
				Message = Message.RESTORE_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}

		[HttpDelete()]
		public async Task<IActionResult> DeleteManyAsync(List<Guid> ids, bool isHardDeleted = false)
		{
			await _sender.Send(new DeleteIndividualScheduleCommand { Ids = ids, isHardDelete = isHardDeleted });
			return Ok(new ApiResponse
			{
				Message = Message.DELETED_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}
	}
}
