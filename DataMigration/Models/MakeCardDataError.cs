using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MakeCardDataError
    {
        /// <summary>
        /// 證件ID,
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 證件類型,1表車輛通行證,2表客戶駐廠證或駐廠工作證
        /// </summary>
        public int? TypeId { get; set; }
        /// <summary>
        /// 出錯異常記錄時間
        /// </summary>
        public DateTime? ErrorDate { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string? Meno { get; set; }
        public bool IsDeleted { get; set; }
    }
}
