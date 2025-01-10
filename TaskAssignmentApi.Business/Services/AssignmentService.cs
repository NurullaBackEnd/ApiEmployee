using TaskAssignmentApi.Core.Entities;
using TaskAssignmentApi.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskAssignmentApi.Business.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public AssignmentService(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public async Task<IEnumerable<Assignment>> GetAllAssignmentsAsync()
        {
            return await _assignmentRepository.GetAllAssignmentsAsync();
        }

        public async Task<Assignment> GetAssignmentByIdAsync(int id)
        {
            return await _assignmentRepository.GetAssignmentByIdAsync(id);
        }

        public async Task AddAssignmentAsync(Assignment assignment)
        {
            await _assignmentRepository.AddAssignmentAsync(assignment);
        }
    }
}
