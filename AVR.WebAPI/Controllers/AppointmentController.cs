using AVR.Application.ServiceImplements;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Appointments;
using CoreApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVR.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllApointment()
        {
            var appointments = await _appointmentService.GetAllAppointmentAsync();
            return CustomResult("Tải dữ liệu thành công.", appointments);
        }

        /*[HttpPost("create-appointment")]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentRequest request)
        {
            var appointment = await _appointmentService.CreateAppointment(request);
            return CustomResult("Tạo cuộc hẹn thành công!", appointment);
        }*/
    }
}
