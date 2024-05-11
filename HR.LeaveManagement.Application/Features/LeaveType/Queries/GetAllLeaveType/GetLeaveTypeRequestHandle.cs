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
    public class GetLeaveTypeRequestHandle : IRequestHandler<GetLeaveTypeRequest, List<GetLeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveType;
        private readonly IMapper _mapper;

        public GetLeaveTypeRequestHandle(ILeaveTypeRepository leaveType,
            IMapper mapper)
        {
            _leaveType = leaveType;
            _mapper = mapper;
        }
        public async Task<List<GetLeaveTypeDto>> Handle(GetLeaveTypeRequest request, CancellationToken cancellationToken)
        {
            //read from db
            var leavetypes = await _leaveType.GetAsync();
            //map to dto
            var data = _mapper.Map<List<GetLeaveTypeDto>>(leavetypes);
            //return data
            return data;
        }
    }
}
