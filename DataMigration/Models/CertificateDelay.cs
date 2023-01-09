using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CertificateDelay
    {
        public int DelayApplyId { get; set; }
        public string? Certificate { get; set; }
        public string? CertificateType { get; set; }
        public DateTime? OldExpirationDate { get; set; }
        public DateTime? NewExpirationDate { get; set; }
        public DateTime? DelayDate { get; set; }
        public string? TableName { get; set; }
    }
}
