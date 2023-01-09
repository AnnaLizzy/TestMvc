using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardCompanyHistory
    {
        public int Id { get; set; }
        public string? CardNumber { get; set; }
        public int? CardId { get; set; }
        public int? CreateId { get; set; }
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public int? CompanyIdnew { get; set; }
    }
}
