using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CheckTemp
    {
        public string Controlname { get; set; } = null!;
        public string Credentialsnumber { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public DateTime? Comfromtime { get; set; }
    }
}
