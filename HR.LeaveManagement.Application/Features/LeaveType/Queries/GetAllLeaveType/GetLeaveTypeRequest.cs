using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public record GetLeaveTypeRequest : IRequest<List<GetLeaveTypeDto>>
    {
    }
}
