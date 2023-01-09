using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class FingerPrint
    {
        public int FingerPrintId { get; set; }
        public string? CredentialsNumber { get; set; }
        public byte[]? FingerprintPicture { get; set; }
        public byte[]? FingerprintMode { get; set; }
        public int? FingerNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
