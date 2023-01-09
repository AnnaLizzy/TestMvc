using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VehiclePermitPhoto
    {
        public int VehiclePermitPhotoId { get; set; }
        public int? VehiclePermitId { get; set; }
        public int? PhotoId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
