using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        public IGenericRepository<ApiLog> ApiLogRepository { get; }
        public IGenericRepository<Account> AccountRepository { get; }
        public IGenericRepository<AccountRole> AccountRoleRepository { get; }
        public IGenericRepository<Apartment> ApartmentRepository { get; }
        public IGenericRepository<ProjectFacility> ProjectFacilityRepository { get; }
        public IGenericRepository<ApartmentImage> ApartmentImageRepository { get; }
        public IGenericRepository<ApartmentInteraction> ApartmentInteractionRepository { get; }

        public IGenericRepository<AgreementUpdateRequest> AgreementUpdateRequestRepository { get; }
        /*public IGenericRepository<ApartmentOwner> ApartmentOwnerRepository { get; }*/
        public IGenericRepository<ApartmentProjectProvider> ApartmentProjectProviderRepository { get; }
        public IGenericRepository<Appointment> AppointmentRepository { get; }
        /*public IGenericRepository<Customer> CustomerRepository { get; }*/
        public IGenericRepository<Deposit> DepositRepository { get; }
        public IGenericRepository<Disbursement> DisbursementRepository { get; }
        public IGenericRepository<DepositProfile> DepositProfileRepository { get; }
        //public IGenericRepository<DepositCancel> DepositCancelRepository { get; }
        //public IGenericRepository<DepositCancelType> DepositCancelTypeRepository { get; }
        public IGenericRepository<Facilities> FacilitiesRepository { get; }
        public IGenericRepository<Feedback> FeedbackRepository { get; }
        /*public IGenericRepository<Management> ManagementRepository { get; }*/
        public IGenericRepository<Notification> NotificationRepository { get; }
        //public IGenericRepository<NotificationType> NotificationTypeRepository { get; }
        public IGenericRepository<ProjectAccessLog> ProjectAccessLogRepository { get; }
        public IGenericRepository<ProjectApartment> ProjectApartmentRepository { get; }
        public IGenericRepository<ProjectFile> ProjectFileRepository { get; }
        public IGenericRepository<ProjectImage> ProjectImageRepository { get; }
        public IGenericRepository<ProjectFinancialContract> ProjectFinancialContractRepository { get; }
        //public IGenericRepository<RequestApartment> RequestApartmentRepository { get; }
        public IGenericRepository<Slot> SlotRepository { get; }
        public IGenericRepository<ApplicationSettings> SettingsRepository { get; }
        /*public IGenericRepository<Staff> StaffRepository { get; }*/
        public IGenericRepository<Transaction> TransactionRepository { get; }
        public IGenericRepository<VR_Access_Log> VRAccessLogRepository { get; }
        public IGenericRepository<VRExperience> VRExperienceRepository { get; }

        public IGenericRepository<Team> TeamRepository { get; }
        public IGenericRepository<TeamMember> TeamMemberRepository { get; }

        public IGenericRepository<ChatMessage> ChatMessageRepository { get; }
        public IGenericRepository<ChatSession> ChatSessionRepository { get; }

        public IGenericRepository<ApartmentOwner> ApartmentOwnerRepository { get; }
        //Bảng thêm

        public IGenericRepository<ApartmentOwnerApartment> ApartmentOwnerApartmentRepository { get; }
        //public IGenericRepository<ProjectApartmentApartment> ProjectApartmentApartmentRepository { get; }
        public IGenericRepository<PropertyRequest> PropertyRequestRepository { get; }
        public IGenericRepository<PropertyVerification> PropertyVerificationRepository { get; }

        public IGenericRepository<AppointmentRequest> AppointmentRequestRepository { get; }
        public IGenericRepository<RequestAssignment> RequestAssignmentRepository { get; }
        public IGenericRepository<LegalDocument> LegalDocumentRepository { get; }



        void Save();
        Task SaveAsync();
        void Dispose();
        Task DisposeAsync();
        void BeginTransaction();
        void CommitTransaction();
        void RollBack();

    }
}
