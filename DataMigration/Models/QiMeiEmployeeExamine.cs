using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class QiMeiEmployeeExamine
    {
        public int TwemployeeId { get; set; }
        public string? Bg { get; set; }
        public string? Bu { get; set; }
        public string? Dept { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public bool Sex { get; set; }
        public string? Leavel { get; set; }
        public string? Post { get; set; }
        public string? Code { get; set; }
        public string? Legal { get; set; }
        public DateTime? EnterDate { get; set; }
        public bool WhetherJob { get; set; }
        public string? Source { get; set; }
        public bool IsDeleted { get; set; }
    }
}
