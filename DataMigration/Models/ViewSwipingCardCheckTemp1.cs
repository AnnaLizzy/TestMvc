using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewSwipingCardCheckTemp1
    {
        public string? CardNumber { get; set; }
        public string? SerialNumber { get; set; }
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
        public DateTime? InureEndDate { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? Name { get; set; }
        public string CompanyName { get; set; } = null!;
        public int CompanyStatus { get; set; }
        public int? CardStatus { get; set; }
        public byte[]? BitImage { get; set; }
    }
}
