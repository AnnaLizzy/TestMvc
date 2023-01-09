using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SecurityList
    {
        public int SecurityListId { get; set; }
        public int? AreaId { get; set; }
        public string? AccidentPeople { get; set; }
        public DateTime? AccidentTime { get; set; }
        public string? AccidentDept { get; set; }
        public string? AccidentPlace { get; set; }
        public int? AccidentTypeId { get; set; }
        public string? Information { get; set; }
        public string? AccidentContent { get; set; }
        public string? DealType { get; set; }
        public string? Progress { get; set; }
        public string? ResponsePeople { get; set; }
        public string? Name { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Fileupload { get; set; }
        public string? Bg { get; set; }
    }
}
