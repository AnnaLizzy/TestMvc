using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models.System;

namespace ViewModel.System
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(X => X.EmployeeNo).NotEmpty().WithMessage("Nhập tên người dùng");
            RuleFor(X => X.Password).NotEmpty().WithMessage("Nhập mật khẩu")
                .MinimumLength(6).WithMessage("Mật khẩu gồm 6 kí tự ! ");
        }
    }
}
