using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CivetIntentList
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? AreaName { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string? NameSend { get; set; }
        public int? Bgid { get; set; }
        public int? AreaId { get; set; }
        public string? Notes { get; set; }
        public int? Type { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Bu { get; set; }
        public string? Posision { get; set; }
    }
}
