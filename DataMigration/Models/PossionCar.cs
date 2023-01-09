using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PossionCar
    {
        public int Id { get; set; }
        public string? UnitApplication { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? Tel { get; set; }
        public DateTime? TimeApplication { get; set; }
        public string? Unit { get; set; }
        public string? TimeIn { get; set; }
        public string? TimeOut { get; set; }
        public int? AreaId { get; set; }
        public string? PossionCar1 { get; set; }
        public string? NumberCar { get; set; }
        public string? Notes { get; set; }
        public string? AppEmpNo { get; set; }
        public string? AppEmpName { get; set; }
    }
}
