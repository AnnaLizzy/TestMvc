﻿using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaRegionHistory
    {
        public DateTime? InsertDate { get; set; }
        public int? AreaRegionId { get; set; }
        public int? Id { get; set; }
        public int? Type { get; set; }
        public string? Meno { get; set; }
    }
}
