using System;
using System.Collections.Generic;
using System.Text;
using WorkFlowPro.Application.ModelsDTO;

namespace WorkFlowPro.Application.Interface
{
    public interface IAuthService
    {
        Task<AuthResponse> RegisterAsync(RegisterRequest request);
        Task<AuthResponse> LoginAsync(LoginRequest request);
    }

}
