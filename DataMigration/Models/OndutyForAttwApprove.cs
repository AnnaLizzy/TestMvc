using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutyForAttwApprove
    {
        public int Id { get; set; }
        public DateTime? DateSign { get; set; }
        public int? AreaId { get; set; }
        public string? NameCheck { get; set; }
        public int? Status { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public int? Frametime { get; set; }
    }
}
