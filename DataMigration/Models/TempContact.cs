using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TempContact
    {
        public int? Pid { get; set; }
        public int? Zid { get; set; }
        public string? ContactPeople { get; set; }
        public string? ContactBg { get; set; }
        public string? ContactUnitExtension { get; set; }
        public string? ContactPhone { get; set; }
        public string? NewAddress { get; set; }
        public string? NewApplyPhone { get; set; }
        public string? EmergencyContact { get; set; }
        public string? EmergencyPhone { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
