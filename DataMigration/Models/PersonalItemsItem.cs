using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PersonalItemsItem
    {
        public int Id { get; set; }
        public int? CategoryType { get; set; }
        public string? Building { get; set; }
        public string? RoomNumber { get; set; }
        public string? BedNumber { get; set; }
        public DateTime? TimeUse { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeId { get; set; }
        public string? RoomMateName { get; set; }
        public string? RoomMateId { get; set; }
        public int? KeyReturn { get; set; }
        public int? AssetReturn { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? TimePassKt { get; set; }
        public DateTime? TimePassMajorPart { get; set; }
        public int? AreaId { get; set; }
        public string? Applicant { get; set; }
        public int? Status { get; set; }
        public string? DocFile { get; set; }
    }
}
