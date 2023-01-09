using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChrEmployeeImage
    {
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public int? Sex { get; set; }
        public string? EmpIdentity { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public int? IsService { get; set; }
        public string? Url { get; set; }
        public string? Md5val { get; set; }
        public int? IsImage { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? IsUpImg { get; set; }
        public DateTime? ImgUpTime { get; set; }
        public string? BgCode { get; set; }
    }
}
