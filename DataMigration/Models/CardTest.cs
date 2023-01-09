using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardTest
    {
        public int CardId { get; set; }
        public int AdminId { get; set; }
        public string? CardNumber { get; set; }
        public string? SerialNumber { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public int? Status { get; set; }
        public string? Color { get; set; }
        public string? Company { get; set; }
        public DateTime? MadeTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? ControlType { get; set; }
        public int? WorkType { get; set; }
        public int? CardModelId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? CardGuid { get; set; }
    }
}
