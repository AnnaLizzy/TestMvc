using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChemistryDocforMaterial
    {
        public int Id { get; set; }
        public int? ChemistryFormId { get; set; }
        public string? MaterialId { get; set; }
        public string? Msds { get; set; }
        public string? Gpkinhdoanh { get; set; }
        public string? TlThue { get; set; }
        public string? GpsxKinhdoanh { get; set; }
        public string? GpVanchuyen { get; set; }
        public string? TucachngVanchuyen { get; set; }
        public string? XacnhanttHoachat { get; set; }
    }
}
