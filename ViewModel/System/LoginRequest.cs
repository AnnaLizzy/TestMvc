using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.System
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Nhập tên người dùng")]        
        public string? EmployeeNo { set; get; }
        [Required(ErrorMessage = "Nhập mât khẩu")]
        [DataType(DataType.Password)]
        public string? Password { set; get; }
        public bool RememberMe { set; get; }
    }
}
