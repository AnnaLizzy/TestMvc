using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ViewModel.System
{
    public class RegisterRequest
    {
        public int UserBeforeLodingId { get; set; }
        public string EmployeeNo { get; set; } = null!;
        [Display(Name = "Tên ")]
        public string EmployeeName { get; set; } = null!;

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public DateTime? CreateTime { get; set; }

        public string Notes { get; set; } = null!;
        public int Bgid { get; set; }
        public int? Area { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
