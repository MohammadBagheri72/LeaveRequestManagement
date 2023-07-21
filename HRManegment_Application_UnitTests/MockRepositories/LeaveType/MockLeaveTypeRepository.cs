using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using Moq;

namespace HRManegment_Application_UnitTests.MockRepositories.LeaveType
{
    public static class MockLeaveTypeRepository
    {
        public static Mock<ILeaveTypeRepository> GetLeaveTypeRepository()
        {
            var leaveTypes = new List<HRManegment_Domain.LeaveType>()
            {
                new HRManegment_Domain.LeaveType()
                {
                    Id = 1,
                    DefaultDay=10,
                    Name="Test Vacation"
                },
                new HRManegment_Domain.LeaveType()
                {
                    Id = 2,
                    DefaultDay=15,
                    Name="Test Sick"
                }
            };
            var mockRepo=new Mock<ILeaveTypeRepository>();
            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(leaveTypes);

            mockRepo.Setup(r=>r.Add(It.IsAny<HRManegment_Domain.LeaveType>()))
                .ReturnsAsync((HRManegment_Domain.LeaveType leavetype) =>
                {
                    leaveTypes.Add(leavetype);
                    return leavetype;
                }
                
            );


            return mockRepo;
        }
    }
}
