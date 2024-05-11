using AutoMapper;
using HR.LeaveManagement.Application.Contacts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Command.CreateLeaveType
{
    
    public class CreateLeaveTypeCommandHandle : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveTypeCommandHandle(IMapper mapper,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //validate

            //map request to database
            var leavetypetoCreate = _mapper.Map<Domain.LeaveType>(request);
            //save database
            await _leaveTypeRepository.CreateAsync(leavetypetoCreate);
            //return data
            return leavetypetoCreate.Id;
        }
    }
}
