using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VeQuestionnaire
    {
        public int QuestionnaireId { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? CarNumber { get; set; }
        public string? Area { get; set; }
        public string? Building { get; set; }
        public string? Result { get; set; }
        public string? Filepath { get; set; }
        public int? Status { get; set; }
        public string? Reason { get; set; }
        public int? Isdelete { get; set; }
        public int? DateNumber { get; set; }
        public string? AreaName { get; set; }
    }
}
