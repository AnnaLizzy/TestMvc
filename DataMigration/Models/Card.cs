using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Card
    {
        public Card()
        {
            InvalidRecords = new HashSet<InvalidRecord>();
            VisitantCertificates = new HashSet<VisitantCertificate>();
        }

        public int CardId { get; set; }
        public int AdminId { get; set; }
        public string? CardNumber { get; set; }
        public string? SerialNumber { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public int? Status { get; set; }
        public string? Color { get; set; }
        public string? Company { get; set; }
        public DateTime? MadeTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? ControlType { get; set; }
        public int? WorkType { get; set; }
        public int? CardModelId { get; set; }
        public DateTime? DeleteDate { get; set; }
        /// <summary>
        /// 證件補辦使用，相同的CardGuID表示同一個證件的卡
        /// Nó được sử dụng để cấp lại chứng chỉ, cùng một CardGuID có nghĩa là thẻ của cùng một chứng chỉ
        /// </summary>
        public string? CardGuid { get; set; }

        public virtual ICollection<InvalidRecord> InvalidRecords { get; set; }
        public virtual ICollection<VisitantCertificate> VisitantCertificates { get; set; }
    }
}
