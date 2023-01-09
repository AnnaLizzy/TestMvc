using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustWorkInFactoryPerSon
    {
        public int Id { get; set; }
        public int? CustWorkInFactoryId { get; set; }
        public int? TypeId { get; set; }
        public int? ComanyId { get; set; }
        public int? WorkTypeId { get; set; }
        public string? NameVn { get; set; }
        public string? NameCn { get; set; }
        public string? AreaCard { get; set; }
        public string? PeoPleId { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Mobile { get; set; }
        public string? Memo { get; set; }
        public string? ImagePeople { get; set; }
        public string? FileAttach { get; set; }
        public int? NoExcel { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public int? Status { get; set; }
        public int? IsJob { get; set; }
        public int? IsDeleted { get; set; }
        public int? CardId { get; set; }
        public DateTime? StartValidDate { get; set; }
        public DateTime? EndValidDate { get; set; }
        public string? Receipt { get; set; }
        public string? NameAbeviation { get; set; }
        public string? Notes { get; set; }
    }
}
