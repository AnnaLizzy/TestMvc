using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewVehicleCardCheck
    {
        public string? CardNumber { get; set; }
        public string? SerialNumber { get; set; }
        public int? CardStatus { get; set; }
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
        public DateTime? InureEndDate { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? CarNumber { get; set; }
        public int CompanyStatus { get; set; }
        public string CompanyName { get; set; } = null!;
        public DateTime? UpdateTime { get; set; }
    }
}
