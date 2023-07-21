using AutoMapper;
using HRManegment_Application.Contracts.Persistence;
using HRManegment_Application.DTOs.LeaveType;
using HRManegment_Application.Features.LeaveTypes.Handlers.Commands;
using HRManegment_Application.Profiles;
using HRManegment_Application_UnitTests.MockRepositories.LeaveType;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Application_UnitTests.LeaveTypes.Handlears
{
    public class CreateLeaveTypeCommandHandlerTest
    {
        IMapper _mapper;
        Mock<ILeaveTypeRepository> _mockRepository;
        CreateLeaveTypeDto _createLeaveType;
        public CreateLeaveTypeCommandHandlerTest()
        {
            var mapperConfig = new MapperConfiguration(m => m.AddProfile<MappingProfiles>());
            _mapper = mapperConfig.CreateMapper();
            _mockRepository = MockLeaveTypeRepository.GetLeaveTypeRepository();
            _createLeaveType = new CreateLeaveTypeDto()
            {
                DefaultDay = 14,
                Name = "Fore Test"
            };
        }

        [Fact]
        public async Task CreateLeaveTypeHandlerTest()
        {
            var handler = new CreateLeaveTypeCommandHandler(_mockRepository.Object, _mapper);
            var result =await handler.Handle(new HRManegment_Application.Features.LeaveTypes.Requests.Commands
                .CreateLeaveTypeCommandRequest()
            {
                CreateLeaveTypeDto = _createLeaveType
            }, CancellationToken.None);

            result.ShouldBeOfType<int>();
            
        }
    }
}
