using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Merchandise
    {
        public int Id { get; set; }
        public int? Area { get; set; }
        public string? Unit { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? UserTime { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public string? CarNumber { get; set; }
        public string? CarType { get; set; }
        public string? NameTool { get; set; }
        public string? EmployeeNoApp { get; set; }
        public string? EmployeeNameApp { get; set; }
        public string? ExtTel { get; set; }
        public int? Type { get; set; }
        public string? Notes { get; set; }
        public int? Bg { get; set; }
        public string? ImageIn { get; set; }
        public string? ImageOut { get; set; }
        public int? Secur { get; set; }
        public int? Bgid { get; set; }
        public string? Mobile { get; set; }
        public string? Address { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public byte[]? ImageInBye { get; set; }
        public byte[]? ImageOutBye { get; set; }
        public byte[]? Image1Bye { get; set; }
        public byte[]? Image2Bye { get; set; }
        public byte[]? Image3Bye { get; set; }
        public byte[]? Image4Bye { get; set; }
    }
}
