using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class UnderWriteFlow
    {
        public int UnderWriteFlowId { get; set; }
        public int TypeId { get; set; }
        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime? UnderWriteDate { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public int Leavel { get; set; }
        public int Order { get; set; }
        public string? ParameterCode { get; set; }
        public bool IsDeleted { get; set; }
        public string? Meno { get; set; }
        public string? CreateEmployeeNo { get; set; }
        public string? Notes { get; set; }
    }
}
