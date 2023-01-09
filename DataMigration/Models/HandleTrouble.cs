using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class HandleTrouble
    {
        public int Id { get; set; }
        public int? AreaId { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? EmpNoRece { get; set; }
        public string? EmpNameRece { get; set; }
        public string? MethodRece { get; set; }
        public string? EmpNoArr { get; set; }
        public string? EmpNameArr { get; set; }
        public string? MothodArr { get; set; }
        public int? Status { get; set; }
        public string? ReceTime { get; set; }
        public int? TroubleType { get; set; }
        public string? OtherTrouble { get; set; }
        public string? TroubleContent { get; set; }
        public string? Memo { get; set; }
        public string? HandNameCn { get; set; }
        public string? HandNameVn { get; set; }
        public string? HandExt { get; set; }
        public string? HandMobile { get; set; }
        public string? HandNotes { get; set; }
        public int? Active { get; set; }
        public string? HandResult { get; set; }
        public string? HandTime { get; set; }
        public string? HandMemo { get; set; }
        public string? EmpNoApp { get; set; }
        public string? EmpNameApp { get; set; }
        public string? HandEmpNo { get; set; }
        public DateTime? TimeSend { get; set; }
    }
}
