using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TroubleImage
    {
        public int Id { get; set; }
        public int? Idtrouble { get; set; }
        public string? ImageTrouble { get; set; }
        public int? Type { get; set; }
    }
}
