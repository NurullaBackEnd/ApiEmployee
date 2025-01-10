using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAssignmentApi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskAssignmentApi.Core.Interfaces
{
    public interface IAssignmentRepository
    {
        Task<IEnumerable<Assignment>> GetAllAssignmentsAsync();
        Task<Assignment> GetAssignmentByIdAsync(int id);
        Task AddAssignmentAsync(Assignment assignment);
    }
}
