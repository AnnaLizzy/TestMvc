using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewNblacklist
    {
        public int Blid { get; set; }
        public string? Applyname { get; set; }
        public string? Sex { get; set; }
        public string? Cardtype { get; set; }
        public string? Cardnumber { get; set; }
        public string? Blacktype { get; set; }
        public string? Explain { get; set; }
        public string? Cause { get; set; }
        public string? Inuredate { get; set; }
        public string? Approver { get; set; }
        public string? Remark { get; set; }
        public string? Lasteditby { get; set; }
        public DateTime? Lasteditdt { get; set; }
        public int? Cardid { get; set; }
        public string? Oldcardstatus { get; set; }
        public string? Imgurl { get; set; }
        public string? Isright { get; set; }
        public string? Cardnumber1 { get; set; }
        public string? SourceTag { get; set; }
    }
}
