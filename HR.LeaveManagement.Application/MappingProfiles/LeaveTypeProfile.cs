using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetailLeaveType;
using HR.LeaveManagement.Domain;


namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<GetLeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, GetDetailLeaveTypeDto>();
            
        }
    }
}
