using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardAdded
    {
        public int CardAddedId { get; set; }
        public int? CardId { get; set; }
        /// <summary>
        /// 1 卡損壞補辦，2卡遺失補辦
        /// </summary>
        public int? CardAddedType { get; set; }
        /// <summary>
        /// 1 待收取資料，2待審核，3產生新卡
        /// </summary>
        public int? CardAddedStatus { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? Reasons { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? AdminId { get; set; }
        public string? Ip { get; set; }
        public string? Mac { get; set; }
        public string? Ext { get; set; }
    }
}
