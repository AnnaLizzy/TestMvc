using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewNcarBlackList
    {
        public int Blid { get; set; }
        public string? Carlicense { get; set; }
        public string? Carmodel { get; set; }
        public string? Carcolor { get; set; }
        public string? Blacktype { get; set; }
        public string? Explain { get; set; }
        public string? Cause { get; set; }
        public DateTime? Inuredate { get; set; }
        public string? Approver { get; set; }
        public string? Remark { get; set; }
        public string? Edituser { get; set; }
        public DateTime? Editdate { get; set; }
        public int? Cardid { get; set; }
        public string? Oldcardstatus { get; set; }
        public string? Isdelete { get; set; }
        public string? Iseffective { get; set; }
    }
}
