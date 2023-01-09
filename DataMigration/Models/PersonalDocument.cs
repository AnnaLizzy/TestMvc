using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PersonalDocument
    {
        public int PersonalDocumentsId { get; set; }
        public int CardType { get; set; }
        public string? CardId { get; set; }
        public string Idcode { get; set; } = null!;
        public string? Name { get; set; }
        public bool? Sex { get; set; }
        public string? Nation { get; set; }
        public DateTime? Birthday { get; set; }
        public string? ValidDate { get; set; }
        public string? Address { get; set; }
        public string? DepartMent { get; set; }
        public byte[]? BitImage { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateTime { get; set; }
        public string? Creator { get; set; }
        public DateTime? EditTime { get; set; }
        public string? Editor { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string? Deletor { get; set; }
        /// <summary>
        /// 行駛證類型：0行駛證反面，1小型車，其它為行駛證正面，默認為2：&gt;0都是正面,-1不是行駛證類型
        /// </summary>
        public int Xsztype { get; set; }
        public string PersonalDocumentsGuid { get; set; } = null!;
        public string? Xszguid { get; set; }
    }
}
