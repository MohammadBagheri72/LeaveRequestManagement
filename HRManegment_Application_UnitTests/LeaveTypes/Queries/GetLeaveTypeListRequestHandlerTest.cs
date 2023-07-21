using AutoMapper;
using HRManegment_Application.Contracts.Persistence;
using HRManegment_Application.DTOs.LeaveType;
using HRManegment_Application.Features.LeaveTypes.Handlers.Queries;
using HRManegment_Application.Profiles;
using HRManegment_Application_UnitTests.MockRepositories.LeaveType;
using Moq;
using Shouldly;

namespace HRManegment_Application_UnitTests.LeaveTypes.Queries
{
    public class GetLeaveTypeListRequestHandlerTest
    {
        IMapper _mapper;
        Mock<ILeaveTypeRepository> _mockRepository;
        public GetLeaveTypeListRequestHandlerTest()
        {
            _mockRepository = MockLeaveTypeRepository.GetLeaveTypeRepository();
            var mapperconfiguration = new MapperConfiguration(m => m.AddProfile<MappingProfiles>());
            _mapper = mapperconfiguration.CreateMapper();
        }
        [Fact]
        public async Task GetLeaveTypeListTest()
        {
            var handler = new GetLeaveTypeListRequestHandler(_mockRepository.Object,_mapper);
            var result =await handler.Handle(new HRManegment_Application.Features.LeaveTypes.Requests.Queries.GetLeaveTypeListRequest(), CancellationToken.None);
            result.ShouldBeOfType<List<LeaveTypeDto>>();
            result.Count.ShouldBe(2);


        }
    }
}
