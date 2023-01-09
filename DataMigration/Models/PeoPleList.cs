using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PeoPleList
    {
        public int Idlist { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? EmpName { get; set; }
        public DateTime? Date { get; set; }
        public string? Idno { get; set; }
        public int? CreType { get; set; }
        public string? IdcreType { get; set; }
        public string? FileCreType { get; set; }
        public string? Idpre { get; set; }
        public string? FilePre { get; set; }
        public string? Memo { get; set; }
        public string? Idatld { get; set; }
        public string? ImageAtld { get; set; }
        public string? ImagePeople { get; set; }
    }
}
