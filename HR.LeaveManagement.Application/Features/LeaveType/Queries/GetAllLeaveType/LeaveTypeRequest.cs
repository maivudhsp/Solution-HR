using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public record LeaveTypeRequest : IRequest<List<LeaveTypeDto>>
    {
    }
}
