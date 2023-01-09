using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class BlackList
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PeopleId { get; set; }
        public string? NumberCar { get; set; }
        public DateTime? TimeBlock { get; set; }
        public string? Memo { get; set; }
        public string? EmpNo { get; set; }
        public int? Deleted { get; set; }
        public DateTime? TimeApplication { get; set; }
    }
}
