using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustWorkInFactory
    {
        public int Id { get; set; }
        public string? CreateEmpNo { get; set; }
        public string? CreateEmpName { get; set; }
        public string? CreateBuname { get; set; }
        public string? ExcTel { get; set; }
        public string? Mobile { get; set; }
        public string? Notes { get; set; }
        public int? Bgid { get; set; }
        public int? AreaId { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public int? Status { get; set; }
        public string? Memo { get; set; }
        public string? FileExcel { get; set; }
        public int? Type { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? EndValidTimeFirst { get; set; }
    }
}
