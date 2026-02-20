using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowPro.Domain.Entities
{
    public class WorkTask
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
