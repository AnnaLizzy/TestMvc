using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ListPosisionCar
    {
        public int Id { get; set; }
        public int? Area { get; set; }
        public string? PossionName { get; set; }
        public int? IsDeleted { get; set; }
        public int? Status { get; set; }
    }
}
