using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskAssignmentApi.Core.Entities
{
    public class Assignment
    {
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
