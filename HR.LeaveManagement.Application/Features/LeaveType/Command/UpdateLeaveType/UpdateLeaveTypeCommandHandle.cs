using AutoMapper;
using HR.LeaveManagement.Application.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Command.UpdateLeaveType
{
    public class UpdateLeaveTypeCommandHandle : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveTypeCommandHandle(IMapper mapper,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //validate

            //map request to database
            var leavetypetoUpdate = _mapper.Map<Domain.LeaveType>(request);
            //save database
            await _leaveTypeRepository.UpdateAsync(leavetypetoUpdate);
            //return data
            return Unit.Value;
        }
    }
}
