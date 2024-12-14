using AVR.Application.Services;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AVR.WebAPI.Controllers
{
    [Route("api/v1/apartment-images")]
    [ApiController]
    public class ApartmentImageController : BaseController
    {
        private readonly IApartmentImageService _apartmentImageService;

        public ApartmentImageController(IApartmentImageService apartmentImageService)
        {
            _apartmentImageService = apartmentImageService;
        }

        // DELETE api/v1/apartment-images/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApartmentImage(Guid id)
        {
            await _apartmentImageService.DeleteApartmentImageAsync(id);
            return CustomResult("Xóa Apartment Image thành công.");
        }
    }
}
