using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Camera
    {
        public int Id { get; set; }
        public int? Bgid { get; set; }
        public string? Unit { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? EmpTel { get; set; }
        public int? Status { get; set; }
        public int? IsDeleted { get; set; }
        public string? NoiDung { get; set; }
        public DateTime? TimeApplication { get; set; }
        public int? Result { get; set; }
        public string? CheckData { get; set; }
        public int? Monitor { get; set; }
        public int? Position { get; set; }
        public int? Area { get; set; }
        public string? Notes { get; set; }
    }
}
