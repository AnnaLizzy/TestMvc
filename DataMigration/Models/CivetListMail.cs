using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CivetListMail
    {
        public int Id { get; set; }
        public int? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string? ListMail { get; set; }
    }
}
