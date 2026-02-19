using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowPro.Application.ModelsDTO
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }

}
