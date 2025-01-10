using Microsoft.AspNetCore.Mvc;
using TaskAssignmentApi.Core.Entities;
using TaskAssignmentApi.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskAssignmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentsController(IAssignmentService assignmentService)
        {
            _assignmentService = assignmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAssignments()
        {
            var assignments = await _assignmentService.GetAllAssignmentsAsync();
            return Ok(assignments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAssignment(int id)
        {
            var assignment = await _assignmentService.GetAssignmentByIdAsync(id);
            if (assignment == null) return NotFound();
            return Ok(assignment);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAssignment([FromBody] Assignment assignment)
        {
            await _assignmentService.AddAssignmentAsync(assignment);
            return CreatedAtAction(nameof(GetAssignment), new { id = assignment.Id }, assignment);
        }
    }
}
