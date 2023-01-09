using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class NotesSendLog
    {
        public int NotesLogId { get; set; }
        public string? NotesTypeName { get; set; }
        public int? Id { get; set; }
        public int? FormstatusId { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public bool? IsBodyHtml { get; set; }
        public bool? ReturnReceipt { get; set; }
        public string? FromDisplayName { get; set; }
        public string? ToAddressList { get; set; }
        public string? CcaddressList { get; set; }
        public string? BccaddressList { get; set; }
        public string? Result { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? SysTime { get; set; }
        public string? Name { get; set; }
        public string? FormName { get; set; }
        public string? Url { get; set; }
    }
}
