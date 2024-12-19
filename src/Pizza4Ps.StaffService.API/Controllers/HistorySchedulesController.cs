using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pizza4Ps.StaffService.API.Constants;
using Pizza4Ps.StaffService.API.Models;
using Pizza4Ps.StaffService.Application.DTOs.HistorySchedules;
using Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.CreateHistorySchedule;
using Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.RestoreHistorySchedule;
using Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Commands.UpdateHistorySchedule;
using Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistorySchedule;
using Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetListHistoryScheduleIgnoreQueryFilter;
using Pizza4Ps.StaffService.Application.UserCases.V1.HistorySchedules.Queries.GetHistoryScheduleById;
using Pizza4Ps.PizzaService.Application.UserCases.V1.HistorySchedules.Commands.DeleteHistorySchedule;

namespace Pizza4Ps.StaffService.API.Controllers
{
	[Route("api/history-schedules")]
	[ApiController]
	public class HistorySchedulesController : ControllerBase
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly ISender _sender;

		public HistorySchedulesController(ISender sender, IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
			_sender = sender;
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync([FromBody] CreateHistoryScheduleDto request)
		{
			var result = await _sender.Send(new CreateHistoryScheduleCommand { CreateHistoryScheduleDto = request });
			return Ok(new ApiResponse
			{
				Result = result,
				Message = Message.CREATED_SUCCESS,
				StatusCode = StatusCodes.Status201Created
			});
		}

		[HttpGet("ignore-filter")]
		public async Task<IActionResult> GetListIgnoreQueryFilterAsync([FromQuery] GetListHistoryScheduleIgnoreQueryFilterDto query)
		{
			var result = await _sender.Send(new GetListHistoryScheduleIgnoreQueryFilterQuery { GetListHistoryScheduleIgnoreQueryFilterDto = query });
			return Ok(new ApiResponse
			{
				Result = result,
				Message = Message.GET_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}

		[HttpGet()]
		public async Task<IActionResult> GetListAsync([FromQuery] GetListHistoryScheduleDto query)
		{
			var result = await _sender.Send(new GetListHistoryScheduleQuery { GetListHistoryScheduleDto = query });
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
			var result = await _sender.Send(new GetHistoryScheduleByIdQuery { Id = id });
			return Ok(new ApiResponse
			{
				Result = result,
				Message = Message.GET_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateAsync([FromRoute] Guid id, [FromBody] UpdateHistoryScheduleDto request)
		{
			var result = await _sender.Send(new UpdateHistoryScheduleCommand { Id = id, UpdateHistoryScheduleDto = request });
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
			await _sender.Send(new RestoreHistoryScheduleCommand { Ids = ids });
			return Ok(new ApiResponse
			{
				Message = Message.RESTORE_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}

		[HttpDelete()]
		public async Task<IActionResult> DeleteManyAsync(List<Guid> ids, bool isHardDeleted = false)
		{
			await _sender.Send(new DeleteHistoryScheduleCommand { Ids = ids, isHardDelete = isHardDeleted });
			return Ok(new ApiResponse
			{
				Message = Message.DELETED_SUCCESS,
				StatusCode = StatusCodes.Status200OK
			});
		}
	}
}
