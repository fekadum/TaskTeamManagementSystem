using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowPro.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set; }

        public string Status { get; set; }
    }
    
}
