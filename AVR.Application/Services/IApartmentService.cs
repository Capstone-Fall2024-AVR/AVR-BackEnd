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

        Task<IEnumerable<CreateApartmentResponse>> SearchApartments(
            string? apartmentName,
            string? address,
            string? district,  // Quận, Huyện
            string? ward,      // Phường, Xã
            List<ApartmentType>? apartmentTypes,   // Danh sách loại hình căn hộ
            decimal? minPrice,
            decimal? maxPrice,
            decimal? minArea,
            decimal? maxArea,
            int? numberOfRooms,
            int? numberOfBathrooms,
            List<Direction>? directions,   // Danh sách hướng nhà
            List<BalconyDirection>? balconyDirections,  // Danh sách hướng ban công
            Guid? accountId,
            bool? userLiked = null,
            int pageIndex = 1,
            int pageSize = 5
        );

    }
}
