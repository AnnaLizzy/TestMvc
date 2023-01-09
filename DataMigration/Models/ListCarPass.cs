using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ListCarPass
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? AreaId { get; set; }
        public string? UnitName { get; set; }
        public string? ExtTel { get; set; }
        public string? Mobile { get; set; }
        public int? Bgid { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        public int? IsDeleted { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? TimeApplication { get; set; }
        public string? Memo { get; set; }
        public string? FileExcel { get; set; }
    }
}
