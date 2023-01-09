using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DriverCompanyMatch
    {
        public int DriverCompanyMatchId { get; set; }
        public string DriverCompanyMatchGuid { get; set; } = null!;
        public int? DriverId { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? MatchDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
