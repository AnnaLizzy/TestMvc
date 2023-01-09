using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MessSenLog
    {
        public int MessId { get; set; }
        public string? UserId { get; set; }
        public DateTime? TimeSend { get; set; }
        public string? Url { get; set; }
        public int? Id { get; set; }
        public int? FormId { get; set; }
        public string? EmpNo { get; set; }
        public int? Status { get; set; }
        public string? FormType { get; set; }
        public string? Subject { get; set; }
        public string? EmpName { get; set; }
        public DateTime? TimeAdd { get; set; }
    }
}
