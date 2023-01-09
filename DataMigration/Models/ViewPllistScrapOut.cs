using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewPllistScrapOut
    {
        public int? ScrapId { get; set; }
        public int? Idcode { get; set; }
        public int? Weights { get; set; }
        public string? Image { get; set; }
        public DateTime? TimeUp { get; set; }
        public int? Type { get; set; }
        public string? TypeNameAbre { get; set; }
        public string? TypeName { get; set; }
        public string? Unit { get; set; }
    }
}
