using Applications.Common;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using ViewModel.System;
using WebApi.Models.System;

namespace WebApp.Areas.Admin.Models
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        //IHttpClientFactory goi WebApI
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            var Json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(Json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.PostAsync("/api/account/authenticate", httpContent);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(await response.Content.ReadAsStringAsync());
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<string>>(await response.Content.ReadAsStringAsync());
        }

       
        

        //public async Task<ApiResult<UserVM>> GetById(Guid id)
        //{
        //    var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
        //    var client = _httpClientFactory.CreateClient();

        //    client.BaseAddress = new Uri(_configuration["BaseAddress"]);
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
        //    var response = await client.GetAsync($"/api/user/{id}");

        //    var body = await response.Content.ReadAsStringAsync();
        //    if (response.IsSuccessStatusCode)
        //        return JsonConvert.DeserializeObject<ApiSuccessResult<UserVM>>(body);

        //    return JsonConvert.DeserializeObject<ApiErrorResult<UserVM>>(body);
        //}

        public async Task<ApiResult<bool>> RegisterUser(RegisterRequest request)
        {
            var Json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(Json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.PostAsync($"/api/account", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }
    }
}
