using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowPro.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
    }

}
