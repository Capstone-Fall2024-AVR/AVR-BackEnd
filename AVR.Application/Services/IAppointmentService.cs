using AVR.Application.ViewModels.Request.Appointments;
using AVR.Application.ViewModels.Response.Appointments;
using AVR.Domain.Entities;
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
    }
}
