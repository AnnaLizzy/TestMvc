using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapContructorIn
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateName { get; set; }
        public string? CreateId { get; set; }
        public string? CreatePhoneNum { get; set; }
        public string? ContructorName { get; set; }
        public DateTime? TimeUse { get; set; }
        public int? Status { get; set; }
        public int? AreaId { get; set; }
        public int? BgId { get; set; }
        public int? CarCount { get; set; }
        public string? ContructorId { get; set; }
        public DateTime? DatetimeSign { get; set; }
        public string? IpSign { get; set; }
        public int? Isdeleted { get; set; }
        public string? NoteSign { get; set; }
        public string? CreateEmail { get; set; }
    }
}
