using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class NvipcardFrom165
    {
        public int Id { get; set; }
        public string? Cardno { get; set; }
        public string? Ecardno { get; set; }
        public string? Carid { get; set; }
        public string? Cardname { get; set; }
        public string? Tel { get; set; }
        public string? Depart { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
