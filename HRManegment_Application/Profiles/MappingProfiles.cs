using AutoMapper;
using HRManegment_Application.DTOs.LeaveAllocation;
using HRManegment_Application.DTOs.LeaveRequest;
using HRManegment_Application.DTOs.LeaveType;
using HRManegment_Domain;


namespace HRManegment_Application.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType,CreateLeaveTypeDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, ChangeLeaveRequestApprovealDto>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation,CreateLeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation,UpdateLeaveAllocationDto>().ReverseMap();
        }
    }
}
