using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SecurityInfor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Idpeople { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? Gender { get; set; }
        public DateTime? DateIn { get; set; }
        public string? PosisionWork { get; set; }
        public string? Address { get; set; }
        public string? CompanyName { get; set; }
        public int? AreaId { get; set; }
        public int? IsDeleted { get; set; }
        public string? FileAtt { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
