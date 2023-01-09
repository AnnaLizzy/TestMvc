using Applications.Common;
using Data.Migration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ViewModel.System;
using WebApi.Models.System;

namespace Applications.User
{
    public class UserService : IUserService
    {

        private readonly UserManager<UserBeforeLoding> _userManager;
        private readonly SignInManager<UserBeforeLoding> _signInManager;
        private readonly IConfiguration _config;

        public UserService(UserManager<UserBeforeLoding> userManager, SignInManager<UserBeforeLoding> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = configuration;
        }
        public async Task<ApiResult<string>> Authentice(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.EmployeeNo);

            if (user == null)
                return new ApiErrorResult<string>("Tài khoản không tồn tại");
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return new ApiErrorResult<string>("Sai mật khẩu");
            }

            var roles = await _userManager.GetRolesAsync(user);

            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Notes),
                new Claim(ClaimTypes.GivenName,user.EmployeeName),
                //new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, string.Join(";", roles)),
                new Claim(ClaimTypes.Name,request.EmployeeNo)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"])) ;
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                        issuer: _config["Tokens:Issuer"],
                        audience: _config["Tokens:Issuer"],
                        claims,
                        expires: DateTime.Now.AddHours(3),
                        signingCredentials: creds);

            return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.EmployeeNo);
            if (user != null)
            {
                return new ApiErrorResult<bool>("Tài khoản đã tồn tại");
            }
            if (await _userManager.FindByEmailAsync(request.Notes) != null)
            {
                return new ApiErrorResult<bool>("Email dã tồn tại");
            }
            var username = request.EmployeeNo;
            user = new UserBeforeLoding()
            {
                UserName = username,
                EmployeeNo = request.EmployeeNo,
                EmployeeName = request.EmployeeName,
                Password = request.Password,
                CreateTime = DateTime.Now,
                Notes = request.Notes,
                Bgid = request.Bgid,
                Area = request.Area,                
                PhoneNumber = request.PhoneNumber,
            };
            var resutl = await _userManager.CreateAsync(user, request.Password);
            if (resutl.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Đăng kí không thành công");
        }
    }
    
}
