using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class UserIdzalo
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? UserId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
