using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VehicleImportRecordFstTier
    {
        public string? Id { get; set; }
        public string Stime { get; set; } = null!;
        public string? CarNum { get; set; }
        public string SDir { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public string? Bak { get; set; }
        public byte? OpenState { get; set; }
        public int Mid { get; set; }
    }
}
