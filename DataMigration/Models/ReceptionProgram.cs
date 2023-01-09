using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ReceptionProgram
    {
        public int ReceptionId { get; set; }
        public int VisitNotCustId { get; set; }
        public DateTime? ReceptionTime { get; set; }
        public string? ReceptionContent { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? Position { get; set; }
    }
}
