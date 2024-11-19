using AVR.Application.ViewModels.Request.Appointments;
using AVR.Application.ViewModels.Response.Appointments;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IAppointmentService
    {

        Task<IEnumerable<CreateAppointmentResponse>> GetAllAppointmentAsync();
        
        Task<CreateAppointmentResponse> GetById (Guid id);


        Task<CreateAppointmentResponse> CreateAppointmentAsync(CreateAppointmentRequest request);
        Task<CreateAppointmentResponse> StartAppointment(Guid appointmentId);
        Task<CreateAppointmentResponse> CompleteAppointment(Guid appointmentId);
        Task<CreateAppointmentResponse> CancelAppointment(Guid appointmentId);
        Task<CreateAppointmentResponse> UpdateAppointmentDate(Guid appointmentId, DateTimeOffset newAppointmentDate, TimeSpan newStartTime, TimeSpan newEndTime);

        Task<(IEnumerable<CreateAppointmentResponse> Results, int TotalItems, int TotalPages)> SearchAppointmentsAsync(
               Guid? customerId = null,
               Guid? apartmentId = null,
               AppointmentStatus? status = null,
               DateTimeOffset? startDate = null,
               DateTimeOffset? endDate = null,
               string? title = null,
               int pageIndex = 1,
               int pageSize = 10);

    }
}
