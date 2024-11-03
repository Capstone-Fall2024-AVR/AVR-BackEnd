using AVR.Application.Services;
using AVR.Application.ViewModels.Request.ApartmentInteractions;
using AVR.Domain.Enums;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/apartment-interactions")]
    [ApiController]
    public class ApartmentInteractionController : BaseController
    {
        private readonly IApartmentInteractionService _apartmentInteractionService;

        public ApartmentInteractionController(IApartmentInteractionService apartmentInteractionService)
        {
            _apartmentInteractionService = apartmentInteractionService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var interactions = await _apartmentInteractionService.GetAllAsync();
            return CustomResult("Loaded successfully.", interactions);
        }

        [HttpGet("{interactionId}")]
        public async Task<IActionResult> GetById(Guid interactionId)
        {
            var interaction = await _apartmentInteractionService.GetByIdAsync(interactionId);
            return CustomResult("Loaded successfully.", interaction);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateApartmentInteractionRequest request)
        {
            var interaction = await _apartmentInteractionService.CreateAsync(request);
            return CustomResult("Created successfully.", interaction);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(
            [FromQuery] Guid? accountId,
            [FromQuery] InteractionType? interactionType,
            [FromQuery] Guid? apartmentId,
            [FromQuery] DateTimeOffset? date,
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10)
        {
            var results = await _apartmentInteractionService.SearchAsync(accountId, interactionType, apartmentId, date, pageIndex, pageSize);
            return CustomResult("Search results", results);
        }

        [HttpDelete("{interactionId}")]
        public async Task<IActionResult> DeleteInteraction(Guid interactionId)
        {
            await _apartmentInteractionService.DeleteInteractionByIdAsync(interactionId);
            return CustomResult("Xóa tương tác thành công");
        }
    }
}
