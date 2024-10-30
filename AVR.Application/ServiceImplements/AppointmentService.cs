using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Appointments;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Application.ViewModels.Response.Appointments;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly UserManager<Account> _userManager;

        public AppointmentService(IConfiguration configuration, IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }

        //Create Appointment
        public async Task<CreateAppointmentResponse> CreateAppointmentAsync(CreateAppointmentRequest request)
        {
            // Kiểm tra xem nhân viên có tồn tại không
            var staff = await _userManager.FindByIdAsync(request.StaffID.ToString());
            if (staff == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy nhân viên này.");
            }

            // Kiểm tra xem tài khoản có vai trò 'Staff' hay không
            var isStaff = await _userManager.IsInRoleAsync(staff, "Staff");
            if (!isStaff)
            {
                throw new CustomException.InvalidDataException("Tài khoản này không có vai trò nhân viên (Staff).");
            }

            var customer = await _userManager.FindByIdAsync(request.CustomerID.ToString());
            if (customer == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy khách hàng này.");
            }

            var apartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (apartment == null)
            {
                throw new CustomException.DataNotFoundException("Không tìm thấy căn hộ này.");
            }

            var appointment = _mapper.Map<Appointment>(request);
            appointment.CreateDate = CoreHelper.SystemTimeNow;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;
            //appointment.AssignedDate = DateTimeOffset.Now;
            appointment.AppointmentStatus = Domain.Enums.AppointmentStatus.Confirmed;
            _unitOfWork.AppointmentRepository.Insert(appointment);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            return response;

        }

        public async Task<IEnumerable<CreateAppointmentResponse>> GetAllAppointmentAsync()
        {
            var appointments = await _unitOfWork.AppointmentRepository.GetAllAsync();
            if (appointments == null)
            {
                throw new CustomException.DataNotFoundException("List trống.");

            }

            var accountResponses = _mapper.Map<IEnumerable<CreateAppointmentResponse>>(appointments);
            return accountResponses;
        }

        public async Task<CreateAppointmentResponse> GetById(Guid id)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(id);
            if (appointment == null) 
            {
                throw new CustomException.DataNotFoundException("Không thấy apointment.");
            }

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            return response;
        }


        // Set Appointment Status to InProcessing
        public async Task<CreateAppointmentResponse> StartAppointment(Guid appointmentId)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }

            appointment.AppointmentStatus = AppointmentStatus.InProcessing;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;

            _unitOfWork.AppointmentRepository.Update(appointment);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<CreateAppointmentResponse>(appointment);
        }

        // Set Appointment Status to Done and update EndTime
        public async Task<CreateAppointmentResponse> CompleteAppointment(Guid appointmentId)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }

            appointment.AppointmentStatus = AppointmentStatus.Done;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;
            appointment.EndTime = TimeSpan.FromTicks(CoreHelper.SystemTimeNow.TimeOfDay.Ticks); // Set EndTime to current time

            _unitOfWork.AppointmentRepository.Update(appointment);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<CreateAppointmentResponse>(appointment);
        }

        // Cancel Appointment and set EndTime to cancellation time
        public async Task<CreateAppointmentResponse> CancelAppointment(Guid appointmentId)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }

            appointment.AppointmentStatus = AppointmentStatus.Canceled;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;
            appointment.EndTime = TimeSpan.FromTicks(CoreHelper.SystemTimeNow.TimeOfDay.Ticks); // Set EndTime to current time

            _unitOfWork.AppointmentRepository.Update(appointment);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<CreateAppointmentResponse>(appointment);
        }

        // Update Appointment Date and Status to Updated
        public async Task<CreateAppointmentResponse> UpdateAppointmentDate(Guid appointmentId, DateTimeOffset newDate, TimeSpan newStartTime, TimeSpan newEndTime)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            if (appointment == null)
            {
                throw new CustomException.DataNotFoundException("Không thấy cuộc hẹn.");
            }

            appointment.AppointmentDate = newDate;
            appointment.StartTime = newStartTime;
            appointment.EndTime = newEndTime;
            appointment.AppointmentStatus = AppointmentStatus.Updated;
            appointment.UpdatedDate = CoreHelper.SystemTimeNow;

            _unitOfWork.AppointmentRepository.Update(appointment);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<CreateAppointmentResponse>(appointment);
        }
    }
}
