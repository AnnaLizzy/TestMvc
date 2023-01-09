using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SecurityTrain
    {
        public int Idtr { get; set; }
        public int? Id { get; set; }
        public DateTime? TimeTrain { get; set; }
        public string? TrainContent { get; set; }
        public int? Status { get; set; }
        public string? Type { get; set; }
        public string? PeopleTrain { get; set; }
    }
}
