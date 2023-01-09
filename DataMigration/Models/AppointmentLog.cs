using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppointmentLog
    {
        public int AppointmentLogId { get; set; }
        public string AppointmentAddressName { get; set; } = null!;
        public DateTime AppointmentDateName { get; set; }
        public string AppointmentTimeName { get; set; } = null!;
        public string AppointmentPeopleNo { get; set; } = null!;
        public string AppointmentStatus { get; set; } = null!;
        public DateTime CreateTime { get; set; }
    }
}
