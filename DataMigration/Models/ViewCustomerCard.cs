using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewCustomerCard
    {
        public string? CertifiCateName { get; set; }
        public string? Name { get; set; }
        public string? NameAbbreviation { get; set; }
        public byte[]? BitImage { get; set; }
        public string? SerialNumber { get; set; }
    }
}
