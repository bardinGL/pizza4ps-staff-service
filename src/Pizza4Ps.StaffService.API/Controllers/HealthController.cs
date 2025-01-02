using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pizza4Ps.StaffService.API.Controllers
{
    [Route("api/health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Healthy");
        }
        [HttpGet("test-staff-service")]
        public async Task<IActionResult> GetTestAsync()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://pizza-service/api/health/test");
            if (response.IsSuccessStatusCode)
            {
                var staffInfo = await response.Content.ReadAsStringAsync();
                return Ok(staffInfo);
            }
            return StatusCode((int)response.StatusCode, "Failed to get staff info");
        }
    }
}
