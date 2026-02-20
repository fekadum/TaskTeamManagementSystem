using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowPro.Application.ModelsDTO
{
    public class CreateTaskDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}
