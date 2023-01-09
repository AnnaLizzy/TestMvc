using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppointmentDateTime
    {
        public int AppointmentDateTimeId { get; set; }
        public string AppointmentDateTimeGuid { get; set; } = null!;
        public string AppointmentAddressGuid { get; set; } = null!;
        public string AppointmentDateGuid { get; set; } = null!;
        public string AppointmentTimeGuid { get; set; } = null!;
        public bool IsDeleted { get; set; }
    }
}
