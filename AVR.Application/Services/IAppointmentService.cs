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
        //Task<CreateAppointmentResponse> CreateAppointment (CreateAppointmentRequest request);
        Task<CreateAppointmentResponse> GetById (Guid id);

    }
}
