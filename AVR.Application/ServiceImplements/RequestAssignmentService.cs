using AutoMapper;
using AVR.Application.Services;
using AVR.Application.ViewModels.Response.RequestAssignments;
using AVR.Domain.CustomException;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using AVR.Domain.Interfaces;
using AVR.Domain.Utils;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ServiceImplements
{
    public class RequestAssignmentService : IRequestAssignmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<Account> _userManager;
        public RequestAssignmentService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<Account> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<RequestAssignmentResponse> AssignRequestAsync(Guid requestId, Guid AssignedTeamMemberID, RequestType requestType)
        {


            var assignment = new RequestAssignment
            {
                RequestId = requestId,
                RequestType = requestType,
                AssignedTeamMemberID = AssignedTeamMemberID,
                Status = RequestAssignmentStatus.InProgress,
                AssignedDate = CoreHelper.SystemTimeNow
            };

            //staff.ActiveAssignmentCount += 1;
            _unitOfWork.RequestAssignmentRepository.Insert(assignment);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<RequestAssignmentResponse>(assignment);

        }
        //GetAll
        public async Task<IEnumerable<RequestAssignmentResponse>> GetAllAsync()
        {
            var assignments = await _unitOfWork.RequestAssignmentRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<RequestAssignmentResponse>>(assignments);
        }

        //GetByID
        public async Task<RequestAssignmentResponse> GetByIdAsync(Guid assignmentId)
        {
            var assignment = await _unitOfWork.RequestAssignmentRepository.GetByIdAsync(assignmentId);
            if (assignment == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu phân công.");

            return _mapper.Map<RequestAssignmentResponse>(assignment);
        }


        //Search
        public async Task<IEnumerable<RequestAssignmentResponse>> SearchAsync(Guid? AssignedTeamMemberID, RequestType? requestType, Guid? requestId, DateTimeOffset? assignedDate, DateTimeOffset? completeDate)
        {
            Expression<Func<RequestAssignment, bool>> filter = a =>
           (!AssignedTeamMemberID.HasValue || a.AssignedTeamMemberID == AssignedTeamMemberID) &&
           (!requestType.HasValue || a.RequestType == requestType) &&
           (!requestId.HasValue || a.RequestId == requestId) &&
           (!assignedDate.HasValue || a.AssignedDate.Date == assignedDate.Value.Date) &&
           (!completeDate.HasValue || a.CompleteDate.HasValue && a.CompleteDate.Value.Date == completeDate.Value.Date);

            var assignments = _unitOfWork.RequestAssignmentRepository.Get(filter);
            return _mapper.Map<IEnumerable<RequestAssignmentResponse>>(assignments);
        }


        //UnAssign
        public async Task<bool> UnassignRequestAsync(Guid assignmentId)
        {
            var assignment = await _unitOfWork.RequestAssignmentRepository.GetByIdAsync(assignmentId);
            if (assignment == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu phân công.");


            _unitOfWork.RequestAssignmentRepository.Delete(assignment);
            await _unitOfWork.SaveAsync();
            return true;
        }

        //Update
        public async Task<RequestAssignmentResponse> UpdateAssignRequestAsync(Guid assignmentId, RequestAssignmentStatus newStatus, DateTimeOffset? completeDate = null)
        {
            var assignment = await _unitOfWork.RequestAssignmentRepository.GetByIdAsync(assignmentId);
            if (assignment == null)
                throw new CustomException.DataNotFoundException("Không tìm thấy yêu cầu phân công.");

            assignment.Status = newStatus;
            assignment.CompleteDate = completeDate ?? CoreHelper.SystemTimeNow;

            _unitOfWork.RequestAssignmentRepository.Update(assignment);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<RequestAssignmentResponse>(assignment);
        }
    }
}
