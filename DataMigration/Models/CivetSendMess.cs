using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CivetSendMess
    {
        public int Id { get; set; }
        public string? FormType { get; set; }
        public string? Subject { get; set; }
        public DateTime? TimeSend { get; set; }
        public int? Status { get; set; }
        public DateTime? TimeAdd { get; set; }
        public string? EmpNo { get; set; }
        public int? FormId { get; set; }
        public string? Url { get; set; }
        public int? Idapp { get; set; }
        public int? Type { get; set; }
    }
}
