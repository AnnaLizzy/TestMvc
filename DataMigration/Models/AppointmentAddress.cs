using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppointmentAddress
    {
        public int AppointmentAddressId { get; set; }
        public string AppointmentAddressGuid { get; set; } = null!;
        public string AppointmentAddressName { get; set; } = null!;
        public bool IsDeleted { get; set; }
    }
}
