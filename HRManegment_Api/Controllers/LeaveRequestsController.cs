using HRManegment_Application.DTOs.LeaveRequest;
using HRManegment_Application.Features.LeaveRequests.Requests.Commands;
using HRManegment_Application.Features.LeaveRequests.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRManegment_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LeaveRequestsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<LeaveRequestsController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveRequestListDto>>> Get()
        {
            var leaveRequests = await _mediator.Send(new GetLeaveRequestListRequest());
            return Ok(leaveRequests);

        }

        // GET api/<LeaveRequestsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveRequestDto>> Get(int id)
        {
            var leaveRequest = await _mediator.Send(new GetLeaveRequestDetailRequest() { Id = id });
            return Ok(leaveRequest);
        }

        // POST api/<LeaveRequestsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLeaveRequestDto leaveRequest)
        {
            var command = new CreateLeaveRequestCommandRequest() { CreateLeaveRequestDto = leaveRequest };
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<LeaveRequestsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveRequestDto leaveRequest)
        {
            var command = new UpdateLeaveRequestCommandRequest() { UpdateLeaveRequestDto = leaveRequest };
            await _mediator.Send(command);
            return NoContent();
        }
        // PUT api/<LeaveRequestsController>changeapproval/5
        [HttpPut("changeapproval/{id}")]
        public async Task<ActionResult> ChangeApproval(int id, [FromBody] ChangeLeaveRequestApprovealDto changeLeaveRequest)
        {
            var command = new ChangeLeaveRequestApprovealCommandRequest() { ChangeLeaveRequestApprovealDto = changeLeaveRequest };
            await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<LeaveRequestsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveRequestCommandRequest() { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
