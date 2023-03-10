using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewVehiclePermitEmployee
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? Address { get; set; }
        public int Type { get; set; }
        public string? SerialNumber { get; set; }
    }
}
