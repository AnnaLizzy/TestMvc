using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class InvalidRecord
    {
        public InvalidRecord()
        {
            RecovertRecords = new HashSet<RecovertRecord>();
        }

        public int InvalidId { get; set; }
        public int? CardId { get; set; }
        public string? InvalidReasons { get; set; }
        public DateTime? Invalid { get; set; }
        public int? AdminId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Effective { get; set; }
        /// <summary>
        /// 0為作廢未處理，1為證件收回，2為交賠償金，3為補卡
        /// 0 có nghĩa là hết hiệu lực nhưng không được xử lý,
        /// 1 có nghĩa là giấy chứng nhận bị thu hồi,
        /// 2 có nghĩa là bồi thường, 3 có nghĩa là thẻ được cấp lại
        /// </summary>
        public int RecoveryType { get; set; }
        public int? QuitApplyId { get; set; }

        public virtual Card? Card { get; set; }
        public virtual ICollection<RecovertRecord> RecovertRecords { get; set; }
    }
}
