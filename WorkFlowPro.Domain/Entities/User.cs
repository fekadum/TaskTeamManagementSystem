using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WorkFlowPro.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
    }

}
