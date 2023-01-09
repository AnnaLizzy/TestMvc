using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppointmentTime
    {
        public int AppointmentTimeId { get; set; }
        public string AppointmentTimeGuid { get; set; } = null!;
        /// <summary>
        /// 預約時段名稱
        /// </summary>
        public string AppointmentTimeName { get; set; } = null!;
        /// <summary>
        /// 預約時段開始時間
        /// </summary>
        public string AppointmentTimeBeginTime { get; set; } = null!;
        /// <summary>
        /// 預約時段結束時間
        /// </summary>
        public string AppointmentTimeEndTime { get; set; } = null!;
        /// <summary>
        /// 人數
        /// </summary>
        public int PeopleCount { get; set; }
        public bool IsDeleted { get; set; }
        public int OrderIndex { get; set; }
    }
}
