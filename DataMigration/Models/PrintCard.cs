using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PrintCard
    {
        public int Idprint { get; set; }
        public string? NamePrint { get; set; }
        public DateTime? TimePrint { get; set; }
        public int? Id { get; set; }
        public int? TypeCard { get; set; }
    }
}
