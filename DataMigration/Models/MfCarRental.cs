using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MfCarRental
    {
        public int MfCarRentalId { get; set; }
        public string? CompanyName { get; set; }
        public string? CredentalsNumber { get; set; }
        public string? MfAddress { get; set; }
        public string? Contacter { get; set; }
        public string? ContacterPhone { get; set; }
        public string? MfCode { get; set; }
        public string? CarNumber { get; set; }
        public string? Category { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }
        public int? Number { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
