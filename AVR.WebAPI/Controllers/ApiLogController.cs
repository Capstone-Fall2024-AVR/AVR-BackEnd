using AVR.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/logs")]
    public class ApiLogController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApiLogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetApiLogs([FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 10)
        {
            var logs = _unitOfWork.ApiLogRepository.Get(orderBy: q => q.OrderByDescending(l => l.Timestamp), pageIndex: pageIndex, pageSize: pageSize);
            int totalItems = await _unitOfWork.ApiLogRepository.CountAsync(null);
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            return Ok(new
            {
                Logs = logs,
                TotalItems = totalItems,
                TotalPages = totalPages
            });
        }
    }

}
