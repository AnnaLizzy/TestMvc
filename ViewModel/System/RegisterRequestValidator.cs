using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.System
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(c => c.Notes).NotEmpty().WithMessage("Không bỏ trống trường này !")
               .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
               .WithMessage("Định dạng Email không đúng !");
            RuleFor(c => c.PhoneNumber).NotEmpty().WithMessage("Không bỏ trống trường này !");
            RuleFor(c => c.EmployeeNo).NotEmpty().WithMessage("Nhập tên mã nhân viên!");
            RuleFor(c => c.EmployeeName).NotEmpty().WithMessage("Nhập tên nhân viên!");
            RuleFor(c => c.Password).NotEmpty().WithMessage("Nhập mật khẩu !")
                .MinimumLength(6).WithMessage("Mật khẩu ít nhất 6 kí tự !");
            //RuleFor(c => c).Custom((request, context) =>
            //{
            //    if (request.Password != request.ConfirmPassword)
            //    {
            //        context.AddFailure("Mật khẩu nhập lại không đúng !");
            //    }
            //});
        }
    }
}
