using Applications.Common;
using ViewModel.System;
using WebApi.Models.System;

namespace Applications.User
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authentice(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
    }
}