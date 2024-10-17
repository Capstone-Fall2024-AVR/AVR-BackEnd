using AVR.Domain.Entities;
using AVR.Domain.Interfaces;
using AVR.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Repository
{

    public class UnitOfWork : IUnitOfWork
    {

        private MyDbContext _context = new MyDbContext();

        private IGenericRepository<PropertyRequest> _propertyRequestRepository;
        private IGenericRepository<PropertyVerification> _propertyVerificationRepository;
        private IGenericRepository<Account> _accountRepository;
        private IGenericRepository<AccountRole> _accountRoleRepository;
        private IGenericRepository<Apartment> _apartmentRepository;
        private IGenericRepository<ApartmentFacility> _apartmentFacilityRepository;
        private IGenericRepository<ApartmentImage> _apartmentImageRepository;
        private IGenericRepository<ApartmentInteraction> _apartmentInteractionRepository;
        /*private IGenericRepository<ApartmentOwner> _apartmentOwnerRepository;*/
        private IGenericRepository<ApartmentProjectProvider> _apartmentProjectProviderRepository;
        private IGenericRepository<Appointment> _appointmentRepository;
        /*private IGenericRepository<Customer> _customerRepository;*/
        private IGenericRepository<Deposit> _depositRepository;
        private IGenericRepository<DepositCancel> _depositCancelRepository;
        private IGenericRepository<DepositCancelType> _depositCancelTypeRepository;
        private IGenericRepository<Facilities> _facilitiesRepository;
        private IGenericRepository<Feedback> _feedbackRepository;
        /*private IGenericRepository<Management> _managementRepository;*/
        private IGenericRepository<Notification> _notificationRepository;
        private IGenericRepository<NotificationType> _notificationTypeRepository;
        private IGenericRepository<ProjectAccessLog> _projectAccessLogRepository;
        private IGenericRepository<ProjectApartment> _projectApartmentRepository;
        private IGenericRepository<ProjectImage> _projectImageRepository;
        private IGenericRepository<RequestApartment> _requestApartmentRepository;
        private IGenericRepository<Slot> _slotRepository;
        /*private IGenericRepository<Staff> _staffRepository;*/
        private IGenericRepository<Transaction> _transactionRepository;
        private IGenericRepository<VR_Access_Log> _vrAccessLogRepository;
        private IGenericRepository<VRExperience> _vrExperienceRepository;


        //Bảng thêm
        private IGenericRepository<ApartmentOwnerApartment> _apartmentOwnerApartmentRepository;
        //private IGenericRepository<ProjectApartmentApartment> _projectApartmentApartmentRepository;


        public UnitOfWork()
        {
        }

        public IGenericRepository<PropertyRequest> PropertyRequestRepository
        {
            get
            {

                if (_propertyRequestRepository == null)
                {
                    _propertyRequestRepository = new GenericRepository<PropertyRequest>(_context);
                }
                return _propertyRequestRepository;
            }
        }

        public IGenericRepository<PropertyVerification> PropertyVerificationRepository
        {
            get
            {

                if (_propertyVerificationRepository == null)
                {
                    _propertyVerificationRepository = new GenericRepository<PropertyVerification>(_context);
                }
                return _propertyVerificationRepository;
            }
        }

        public IGenericRepository<Account> AccountRepository
        {
            get
            {

                if (_accountRepository == null)
                {
                    _accountRepository = new GenericRepository<Account>(_context);
                }
                return _accountRepository;
            }
        }


        public IGenericRepository<AccountRole> AccountRoleRepository
        {
            get
            {

                if (_accountRoleRepository == null)
                {
                    _accountRoleRepository = new GenericRepository<AccountRole>(_context);
                }
                return _accountRoleRepository;
            }
        }

        public IGenericRepository<Apartment> ApartmentRepository
        {
            get
            {

                if (_apartmentRepository == null)
                {
                    _apartmentRepository = new GenericRepository<Apartment>(_context);
                }
                return _apartmentRepository;
            }
        }

        public IGenericRepository<ApartmentFacility> ApartmentFacilityRepository
        {
            get
            {

                if (_apartmentFacilityRepository == null)
                {
                    _apartmentFacilityRepository = new GenericRepository<ApartmentFacility>(_context);
                }
                return _apartmentFacilityRepository;
            }
        }

        public IGenericRepository<ApartmentImage> ApartmentImageRepository
        {
            get
            {

                if (_apartmentImageRepository == null)
                {
                    _apartmentImageRepository = new GenericRepository<ApartmentImage>(_context);
                }
                return _apartmentImageRepository;
            }
        }

        public IGenericRepository<ApartmentInteraction> ApartmentInteractionRepository
        {
            get
            {

                if (_apartmentInteractionRepository == null)
                {
                    _apartmentInteractionRepository = new GenericRepository<ApartmentInteraction>(_context);
                }
                return _apartmentInteractionRepository;
            }
        }

        /*public IGenericRepository<ApartmentOwner> ApartmentOwnerRepository
        {
            get
            {

                if (_apartmentOwnerRepository == null)
                {
                    _apartmentOwnerRepository = new GenericRepository<ApartmentOwner>(_context);
                }
                return _apartmentOwnerRepository;
            }
        }*/

        public IGenericRepository<ApartmentProjectProvider> ApartmentProjectProviderRepository
        {
            get
            {

                if (_apartmentProjectProviderRepository == null)
                {
                    _apartmentProjectProviderRepository = new GenericRepository<ApartmentProjectProvider>(_context);
                }
                return _apartmentProjectProviderRepository;
            }
        }

        public IGenericRepository<Appointment> AppointmentRepository
        {
            get
            {

                if (_appointmentRepository == null)
                {
                    _appointmentRepository = new GenericRepository<Appointment>(_context);
                }
                return _appointmentRepository;
            }
        }

        /*public IGenericRepository<Customer> CustomerRepository
        {
            get
            {

                if (_customerRepository == null)
                {
                    _customerRepository = new GenericRepository<Customer>(_context);
                }
                return _customerRepository;
            }
        }*/

        public IGenericRepository<Deposit> DepositRepository
        {
            get
            {

                if (_depositRepository == null)
                {
                    _depositRepository = new GenericRepository<Deposit>(_context);
                }
                return _depositRepository;
            }
        }

        public IGenericRepository<DepositCancel> DepositCancelRepository
        {
            get
            {

                if (_depositCancelRepository == null)
                {
                    _depositCancelRepository = new GenericRepository<DepositCancel>(_context);
                }
                return _depositCancelRepository;
            }
        }

        public IGenericRepository<DepositCancelType> DepositCancelTypeRepository
        {
            get
            {

                if (_depositCancelTypeRepository == null)
                {
                    _depositCancelTypeRepository = new GenericRepository<DepositCancelType>(_context);
                }
                return _depositCancelTypeRepository;
            }
        }

        public IGenericRepository<Facilities> FacilitiesRepository
        {
            get
            {

                if (_facilitiesRepository == null)
                {
                    _facilitiesRepository = new GenericRepository<Facilities>(_context);
                }
                return _facilitiesRepository;
            }
        }

        public IGenericRepository<Feedback> FeedbackRepository
        {
            get
            {

                if (_feedbackRepository == null)
                {
                    _feedbackRepository = new GenericRepository<Feedback>(_context);
                }
                return _feedbackRepository;
            }
        }

        /*public IGenericRepository<Management> ManagementRepository
        {
            get
            {

                if (_managementRepository == null)
                {
                    _managementRepository = new GenericRepository<Management>(_context);
                }
                return _managementRepository;
            }
        }*/

        public IGenericRepository<Notification> NotificationRepository
        {
            get
            {

                if (_notificationRepository == null)
                {
                    _notificationRepository = new GenericRepository<Notification>(_context);
                }
                return _notificationRepository;
            }
        }

        public IGenericRepository<NotificationType> NotificationTypeRepository
        {
            get
            {

                if (_notificationTypeRepository == null)
                {
                    _notificationTypeRepository = new GenericRepository<NotificationType>(_context);
                }
                return _notificationTypeRepository;
            }
        }

        public IGenericRepository<ProjectAccessLog> ProjectAccessLogRepository
        {
            get
            {

                if (_projectAccessLogRepository == null)
                {
                    _projectAccessLogRepository = new GenericRepository<ProjectAccessLog>(_context);
                }
                return _projectAccessLogRepository;
            }
        }

        public IGenericRepository<ProjectApartment> ProjectApartmentRepository
        {
            get
            {

                if (_projectApartmentRepository == null)
                {
                    _projectApartmentRepository = new GenericRepository<ProjectApartment>(_context);
                }
                return _projectApartmentRepository;
            }
        }

        public IGenericRepository<ProjectImage> ProjectImageRepository
        {
            get
            {

                if (_projectImageRepository == null)
                {
                    _projectImageRepository = new GenericRepository<ProjectImage>(_context);
                }
                return _projectImageRepository;
            }
        }

        public IGenericRepository<RequestApartment> RequestApartmentRepository
        {
            get
            {

                if (_requestApartmentRepository == null)
                {
                    _requestApartmentRepository = new GenericRepository<RequestApartment>(_context);
                }
                return _requestApartmentRepository;
            }
        }

        public IGenericRepository<Slot> SlotRepository
        {
            get
            {

                if (_slotRepository == null)
                {
                    _slotRepository = new GenericRepository<Slot>(_context);
                }
                return _slotRepository;
            }
        }

        /*public IGenericRepository<Staff> StaffRepository
        {
            get
            {

                if (_staffRepository == null)
                {
                    _staffRepository = new GenericRepository<Staff>(_context);
                }
                return _staffRepository;
            }
        }*/

        public IGenericRepository<Transaction> TransactionRepository
        {
            get
            {

                if (_transactionRepository == null)
                {
                    _transactionRepository = new GenericRepository<Transaction>(_context);
                }
                return _transactionRepository;
            }
        }

        public IGenericRepository<VR_Access_Log> VRAccessLogRepository
        {
            get
            {

                if (_vrAccessLogRepository == null)
                {
                    _vrAccessLogRepository = new GenericRepository<VR_Access_Log>(_context);
                }
                return _vrAccessLogRepository;
            }
        }

        public IGenericRepository<VRExperience> VRExperienceRepository
        {
            get
            {

                if (_vrExperienceRepository == null)
                {
                    _vrExperienceRepository = new GenericRepository<VRExperience>(_context);
                }
                return _vrExperienceRepository;
            }
        }


        //Bo sung
        public IGenericRepository<ApartmentOwnerApartment> ApartmentOwnerApartmentRepository
        {
            get
            {

                if (_apartmentOwnerApartmentRepository == null)
                {
                    _apartmentOwnerApartmentRepository = new GenericRepository<ApartmentOwnerApartment>(_context);
                }
                return _apartmentOwnerApartmentRepository;
            }
        }

        /*public IGenericRepository<ProjectApartmentApartment> ProjectApartmentApartmentRepository
        {
            get
            {

                if (_projectApartmentApartmentRepository == null)
                {
                    _projectApartmentApartmentRepository = new GenericRepository<ProjectApartmentApartment>(_context);
                }
                return _projectApartmentApartmentRepository;
            }
        }*/


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual async Task DisposeAsync(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_context != null)
                    {
                        await _context.DisposeAsync();
                    }
                }
            }
            disposed = true;
        }

        public async Task DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public void RollBack()
        {
            _context.Database.RollbackTransaction();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }
    }
}
