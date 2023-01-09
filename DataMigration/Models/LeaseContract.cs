using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class LeaseContract
    {
        public int LeaseContractId { get; set; }
        public string? RentName { get; set; }
        public string? ContractNumber { get; set; }
        public string? Tenant { get; set; }
        public string? FactoryName { get; set; }
        public string? ReportName { get; set; }
        public string? Address { get; set; }
        /// <summary>
        /// 內部 
        ///    外部
        /// </summary>
        public int? Type { get; set; }
        public string? HouseNumber { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public double? TotalArea { get; set; }
        public string? Rate { get; set; }
        public int? Monthly { get; set; }
        /// <summary>
        /// 0 在租  1 停租  2 續租
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 0 未交  1 未交清  2 已交清
        /// </summary>
        public int? PayStatus { get; set; }
        public string? PayYear { get; set; }
        public double? PayNum { get; set; }
        public string? Name { get; set; }
        public string? Tel { get; set; }
        public string? Notes { get; set; }
        public string? Code { get; set; }
        public string? File { get; set; }
    }
}
