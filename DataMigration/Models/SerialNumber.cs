using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SerialNumber
    {
        public string SerialNumber1 { get; set; } = null!;
        public int TypeId { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
