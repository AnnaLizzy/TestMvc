using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SendSm
    {
        public int SendSmsid { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? SendFlag { get; set; }
        public string? SendFlagMemo { get; set; }
    }
}
