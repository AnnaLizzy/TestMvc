using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustWorkInFactoryAdminProc
    {
        public int ProcAdminId { get; set; }
        public int? Id { get; set; }
        public int? CustInfacPersonId { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public int? Leavel { get; set; }
        public DateTime? WorkDate { get; set; }
        public string? Memo { get; set; }
        public int? Status { get; set; }
        public string? RoleName { get; set; }
        public string? Ip { get; set; }
    }
}
