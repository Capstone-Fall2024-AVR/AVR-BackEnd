using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Request.Appointments;
using AVR.Application.ViewModels.Response.Accounts;
using AVR.Application.ViewModels.Response.Appointments;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
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

        /*public async Task<CreateAppointmentResponse> CreateAppointment(CreateAppointmentRequest request)
        {
            var appartment = await _unitOfWork.ApartmentRepository.GetByIdAsync(request.ApartmentID);
            if (appartment == null)
            {
                throw new CustomException.DataNotFoundException("Not found apartment.");
            }



            var appointment = _mapper.Map<Appointment>(request);
            request.AssignedDate = DateTimeOffset.Now;
            request.AppointmentDate = DateTimeOffset.Now;
            request.CreateDate = DateTimeOffset.Now;
            request.UpdateDate = DateTimeOffset.Now;



            request.AppointmentStatus = Domain.Enums.AppointmentStatus.Pending;



            // Find Apartment exist in apartmentOwner
            var ownerApartment = _unitOfWork.ApartmentOwnerApartmentRepository
                                           .Get(x => x.ApartmentID == request.ApartmentID)
                                           .FirstOrDefault();

            if (ownerApartment != null)
            {
                // Kiểm tra xem AccountID có tồn tại trong bảng AspNetUsers hay không
                var owner = _unitOfWork.AccountRepository.GetByID(ownerApartment.AccountID);
                if (owner != null)
                {
                    appointment.ApartmentOwnerID = ownerApartment.AccountID;
                    appointment.ProjectProviderID = null;
                }
                else
                {
                    throw new CustomException.DataNotFoundException("Apartment owner not found in the users database.");
                }
            }
            else
            {
                // Find Apartment exist in project
                var projectApartmentApartment = _unitOfWork.ProjectApartmentApartmentRepository
                                                           .Get(y => y.ApartmentID == request.ApartmentID)
                                                           .FirstOrDefault();
                if (projectApartmentApartment != null)
                {
                    // Lấy ProjectProvider cho căn hộ
                    var projectprovider = _unitOfWork.ProjectApartmentRepository
                                                     .Get(x => x.ProjectApartmentID == projectApartmentApartment.ProjectApartmentID)
                                                     .FirstOrDefault();
                    if (projectprovider != null)
                    {
                        // Kiểm tra xem ProjectProviderID có tồn tại trong bảng AspNetUsers hay không
                        var provider = _unitOfWork.AccountRepository.GetByID(projectprovider.ApartmentProjectProviderID);
                        if (provider != null)
                        {
                            appointment.ProjectProviderID = projectprovider.ApartmentProjectProviderID;
                            appointment.ApartmentOwnerID = null;
                        }
                        else
                        {
                            throw new CustomException.DataNotFoundException("Project provider not found in the users database.");
                        }
                    }
                    else
                    {
                        throw new CustomException.DataNotFoundException("Project provider not found for the apartment.");
                    }
                }
                else
                {
                    throw new CustomException.DataNotFoundException("Apartment does not belong to any owner or project.");
                }
            }


            await _unitOfWork.AppointmentRepository.InsertAsync(appointment);
            await _unitOfWork.SaveAsync();

            var response = _mapper.Map<CreateAppointmentResponse>(appointment);
            return response;

           

        }*/

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
    }
}
