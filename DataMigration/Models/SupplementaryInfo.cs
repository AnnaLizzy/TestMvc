using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SupplementaryInfo
    {
        public int SupplementaryInfoId { get; set; }
        public int? Bgid { get; set; }
        public string? Bu { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public string? EnglishName { get; set; }
        public string? Notes { get; set; }
        public string? Tel { get; set; }
        public string? Nation { get; set; }
        public string? Position { get; set; }
        /// <summary>
        /// 1車輛，2為門禁簽核權限
        /// </summary>
        public int? Type { get; set; }
        public string? Files { get; set; }
        public DateTime? AddTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Bg? Bg { get; set; }
    }
}
