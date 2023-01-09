using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VehiclesEmployee
    {
        public int VehiclesEmployeeId { get; set; }
        public string? Name { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? Reason { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
