using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SignStatus
    {
        public int SignStatusId { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public int? Status { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public DateTime? SignTime { get; set; }
        public string? SignPicture { get; set; }
        public string? Meno { get; set; }
        public string? RandomNum { get; set; }
    }
}
