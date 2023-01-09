using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class GroupChiefExecutive
    {
        public int GroupChiefExecutiveId { get; set; }
        public int Bgid { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public int Type { get; set; }
        public string? Position { get; set; }
        public string? SignatureFile { get; set; }
        public string? Password { get; set; }
        public string? AuthorizationFile { get; set; }
        public bool IsDeleted { get; set; }
        public string? Notes { get; set; }
    }
}
