using Microsoft.EntityFrameworkCore;
using TaskAssignmentApi.Core.Entities;
using TaskAssignmentApi.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskAssignmentApi.DAL.Repositories
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly ApplicationDbContext _context;

        public AssignmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Assignment>> GetAllAssignmentsAsync()
        {
            return await _context.Assignments
                .Include(a => a.Employee)
                .Include(a => a.Topic)
                .Include(a => a.Tag)
                .ToListAsync();
        }

        public async Task<Assignment> GetAssignmentByIdAsync(int id)
        {
            return await _context.Assignments
                .Include(a => a.Employee)
                .Include(a => a.Topic)
                .Include(a => a.Tag)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAssignmentAsync(Assignment assignment)
        {
            await _context.Assignments.AddAsync(assignment);
            await _context.SaveChangesAsync();
        }
    }
}
