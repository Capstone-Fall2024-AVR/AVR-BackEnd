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

        [HttpGet("{appointmentId}")]
        public async Task<IActionResult> GetApointmentById(Guid appointmentId)
        {
            var appointments = await _appointmentService.GetById(appointmentId);
            return CustomResult("Tải dữ liệu thành công.", appointments);
        }

        [HttpPost("create-appointment")]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentRequest request)
        {
            var appointment = await _appointmentService.CreateAppointmentAsync(request);
            return CustomResult("Tạo cuộc hẹn thành công!", appointment);
        }

        [HttpPut("start-appointment/{appointmentId}")]
        public async Task<IActionResult> StartAppointment(Guid appointmentId)
        {
            var appointment = await _appointmentService.StartAppointment(appointmentId);
            return CustomResult("Đã chuyển trạng thái cuộc hẹn sang InProcessing.", appointment);
        }

        [HttpPut("complete-appointment/{appointmentId}")]
        public async Task<IActionResult> CompleteAppointment(Guid appointmentId)
        {
            var appointment = await _appointmentService.CompleteAppointment(appointmentId);
            return CustomResult("Đã hoàn thành cuộc hẹn.", appointment);
        }

        [HttpPut("cancel-appointment/{appointmentId}")]
        public async Task<IActionResult> CancelAppointment(Guid appointmentId)
        {
            var appointment = await _appointmentService.CancelAppointment(appointmentId);
            return CustomResult("Cuộc hẹn đã được hủy.", appointment);
        }

        [HttpPut("update-appointment/{appointmentId}")]
        public async Task<IActionResult> UpdateAppointment(Guid appointmentId, [FromBody] UpdateAppointmentRequest request)
        {
            var appointment = await _appointmentService.UpdateAppointmentDate(appointmentId, request.NewAppointmentDate, request.NewStartTime, request.NewEndTime);
            return CustomResult("Cập nhật thời gian cuộc hẹn thành công.", appointment);
        }


        [HttpGet("search")]
        public async Task<IActionResult> SearchAppointments([FromQuery] SearchAppointmentsRequest request)
        {
            var (results, totalItems, totalPages) = await _appointmentService.SearchAppointmentsAsync(
                customerId: request.CustomerID,
                apartmentId: request.ApartmentID,
                status: request.Status,
                startDate: request.StartDate,
                endDate: request.EndDate,
                title: request.Title,
                teamId: request.TeamID,
                pageIndex: request.PageIndex,
                pageSize: request.PageSize
            );

            var response = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                Appointments = results,
                CurrentPage = request.PageIndex,
                PageSize = request.PageSize
            };

            return CustomResult("Tìm kiếm cuộc hẹn thành công.", response);
        }

    }
}
