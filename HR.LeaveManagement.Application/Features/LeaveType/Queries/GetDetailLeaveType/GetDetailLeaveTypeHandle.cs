using AutoMapper;
using HR.LeaveManagement.Application.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetDetailLeaveType
{
    public class GetDetailLeaveTypeHandle : IRequestHandler<GetDetailLeaveType, GetDetailLeaveTypeDto>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetDetailLeaveTypeHandle(IMapper mapper,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<GetDetailLeaveTypeDto> Handle(GetDetailLeaveType request,
            CancellationToken cancellationToken)
        {
            //get from database
            var leavetype = await _leaveTypeRepository.GetByIdAsync(request.id);
            //map data to dto
            var data =_mapper.Map<GetDetailLeaveTypeDto>(leavetype);
            //return data
            return data;
        }
    }
}
