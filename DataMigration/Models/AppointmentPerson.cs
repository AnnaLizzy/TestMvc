using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppointmentPerson
    {
        public int AppointmentPeopleId { get; set; }
        public string AppointmentPeopleGuid { get; set; } = null!;
        public string AppointmentDateTimeGuid { get; set; } = null!;
        /// <summary>
        /// 工號
        /// </summary>
        public string AppointmentPeopleNo { get; set; } = null!;
        /// <summary>
        /// 預約狀態:0已經預約,3取消預約
        /// </summary>
        public int AppointmentStatus { get; set; }
    }
}
