﻿using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Pllist
    {
        public int Id { get; set; }
        public string? CodePl { get; set; }
        public string? NamePl { get; set; }
        public string? Unit { get; set; }
        public int? IsDeleted { get; set; }
        public int? Bgid { get; set; }
        public int? SpecificWeight { get; set; }
        public int? Type { get; set; }
        public int? AreaId { get; set; }
    }
}
