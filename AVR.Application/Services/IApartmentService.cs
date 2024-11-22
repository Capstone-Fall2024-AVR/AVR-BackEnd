using AVR.Application.ViewModels.Request.Apartments;
using AVR.Application.ViewModels.Response.Apartments;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IApartmentService
    {
        Task<IEnumerable<CreateApartmentResponse>> GetApartments();
        Task<CreateApartmentResponse> GetApartmentById(Guid id, Guid? accountId);

        //Task<CreateApartmentResponse> CreateApartmentForProject(CreateApartmentForProjectRequest request);
        Task<CreateApartmentResponse> CreateApartment(CreateApartmentRequest request);
        Task<CreateApartmentForOwnerResponse> CreateApartmentForOwnerAsync(CreateApartmentForOwnerRequest request);

        Task<IEnumerable<CreateApartmentResponse>> CreateApartmentList(CreateApartmentListRequest request);

        Task<(IEnumerable<CreateApartmentResponse> Apartments, int TotalItem, int TotalPage)> SearchApartments(
                string? apartmentName,
                string? address,
                string? district,
                string? ward,
                List<ApartmentType>? apartmentTypes,
                List<ApartmentStatus>? apartmentStatuses,
                List<PossessionType>? possessionTypes,
                decimal? minPrice,
                decimal? maxPrice,
                decimal? minArea,
                decimal? maxArea,
                int? numberOfRooms,
                int? numberOfBathrooms,
                List<Direction>? directions,
                List<BalconyDirection>? balconyDirections,
                Guid? accountId,
                Guid? projectId,
                bool? userLiked = null,
                int pageIndex = 1,
                int pageSize = 5);

        Task<CreateApartmentResponse> ApproveApartment(Guid apartmentId);
        Task<CreateApartmentResponse> RejectApartment(Guid apartmentId);

        Task<CreateApartmentResponse> UpdateApartment(Guid apartmentId, UpdateApartmentRequest request);
    }
}
