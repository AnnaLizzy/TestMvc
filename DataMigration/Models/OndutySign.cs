using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutySign
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public DateTime? DateSign { get; set; }
        public int? Status { get; set; }
        public int? AreaId { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public int? Bgid { get; set; }
        public string? Bgname { get; set; }
        public DateTime? StartTimeValid { get; set; }
        public DateTime? EndTimeValid { get; set; }
        public int? Isdeleted { get; set; }
    }
}
