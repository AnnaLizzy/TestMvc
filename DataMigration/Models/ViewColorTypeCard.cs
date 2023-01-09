using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewColorTypeCard
    {
        public int TableType { get; set; }
        public int TypeCard { get; set; }
        public string? Name { get; set; }
        public string? NameCn { get; set; }
        public string? CardNumber { get; set; }
        public string? Company { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Status { get; set; }
        public string? AreaCard { get; set; }
        public string? ImageFile { get; set; }
        public int? ColorType { get; set; }
        public int? Idcard { get; set; }
        public string? WorkTypeNameV { get; set; }
        public string? WorkTypeNameC { get; set; }
    }
}
