using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewContruc
    {
        public int TypeApp { get; set; }
        public int Id { get; set; }
        public string? UnitApplication { get; set; }
        public string? VendorName { get; set; }
        public DateTime? TimeApplication { get; set; }
        public int? AreaId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? NameConstruc { get; set; }
        public string? Office { get; set; }
        public string? ContenAction { get; set; }
        public int? Status { get; set; }
    }
}
