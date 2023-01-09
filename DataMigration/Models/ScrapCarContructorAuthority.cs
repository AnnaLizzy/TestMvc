using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapCarContructorAuthority
    {
        public int Id { get; set; }
        public string? AuthorityId { get; set; }
        public int? Bgid { get; set; }
        public string? EmpLoyeeNo { get; set; }
        public string? EmLoyeeNameV { get; set; }
        public string? Email { get; set; }
        public string? ZaloId { get; set; }
        public int? AreaId { get; set; }
        public int? IsActive { get; set; }
        public int? Isdeleted { get; set; }
        public string? Notes { get; set; }
        public string? NameAbevation { get; set; }
    }
}
