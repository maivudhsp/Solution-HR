using AutoMapper;
using HR.LeaveManagement.Application.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveType
{
    public class LeaveTypeRequestHandle : IRequestHandler<LeaveTypeRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveType;
        private readonly IMapper _mapper;

        public LeaveTypeRequestHandle(ILeaveTypeRepository leaveType,
            IMapper mapper)
        {
            _leaveType = leaveType;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDto>> Handle(LeaveTypeRequest request, CancellationToken cancellationToken)
        {
            //read from db
            var leavetypes = await _leaveType.GetAsync();
            //map to dto
            var data = _mapper.Map<List<LeaveTypeDto>>(leavetypes);
            //return data
            return data;
        }
    }
}
