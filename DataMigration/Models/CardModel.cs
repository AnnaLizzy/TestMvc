using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardModel
    {
        public int CardModelId { get; set; }
        public int? TypeId { get; set; }
        public string? ModelName { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string? ModelImg { get; set; }
    }
}
