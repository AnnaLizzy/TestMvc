using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class WeiCall
    {
        public int WeId { get; set; }
        public int? Id { get; set; }
        public int? Area { get; set; }
        public string? NameCall { get; set; }
        public DateTime? CallTime { get; set; }
        public int? TypeCall { get; set; }
        public string? ContentWei { get; set; }
        public string? NameLis { get; set; }
        public int? Method { get; set; }
        public string? Result { get; set; }
        public int? Status { get; set; }
        public string? Memo { get; set; }
        public DateTime? ApplicationTime { get; set; }
    }
}
