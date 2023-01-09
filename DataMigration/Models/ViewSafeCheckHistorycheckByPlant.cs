using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewSafeCheckHistorycheckByPlant
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public int? Frametime { get; set; }
        public DateTime? Date { get; set; }
        public int? Status { get; set; }
        public int? AreaId { get; set; }
    }
}
