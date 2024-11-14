using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ProjectFinancialContract.CreateProjectFinancialContractRequest;
using AVR.Application.ViewModels.Request.ProjectFinancialContract.UpdateProjectFinancialContractRequest;
using AVR.Application.ViewModels.Response.ProjectFinancialContract;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/financial-contracts")]
    [ApiController]
    public class ProjectFinancialContractController : BaseController
    {
        private readonly IProjectFinancialContractService _financialContractService;

        public ProjectFinancialContractController(IProjectFinancialContractService financialContractService)
        {
            _financialContractService = financialContractService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateProjectFinancialContractRequest request)
        {
            var result = await _financialContractService.CreateAsync(request);
            return CustomResult("Project Financial Contract đã được tạo thành công.", result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _financialContractService.GetByIdAsync(id);
            return CustomResult("Project Financial Contract đã được lấy thành công.", result);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _financialContractService.GetAllAsync();
            return CustomResult("Project Financial Contract đã được tạo thành công.", result);
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProjectFinancialContractRequest request)
        {
            var result = await _financialContractService.UpdateAsync(id, request);
            return CustomResult("Project Financial Contract đã cập nhật tạo thành công.", result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _financialContractService.DeleteAsync(id);
            return NoContent();
        }
    }
}
