using Applications.Common;
using ViewModel.System;
using WebApi.Models.System;

namespace WebApp.Areas.Admin.Models
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        //Task<ApiResult<UserVM>> GetById(Guid id);
        Task<ApiResult<bool>> RegisterUser(RegisterRequest request);
    }
}