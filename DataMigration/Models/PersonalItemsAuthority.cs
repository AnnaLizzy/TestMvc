using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PersonalItemsAuthority
    {
        public int Id { get; set; }
        public string? AuthorityId { get; set; }
        public int? DepartMentSnid { get; set; }
        public string? EmployeeId { get; set; }
        public string? Email { get; set; }
        public string? EmployeeNameT { get; set; }
        public int? AreaId { get; set; }
        public int? Isdeleted { get; set; }
    }
}
