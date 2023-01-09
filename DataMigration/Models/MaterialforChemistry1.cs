using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MaterialforChemistry1
    {
        public int Id { get; set; }
        public int ChemistryFormId { get; set; }
        public string? MaterialId { get; set; }
        public string? MaterialName { get; set; }
        public int FireTemp { get; set; }
        public double? Mass { get; set; }
        public int? Amount { get; set; }
        public double? TotalMass { get; set; }
        public double? MassofMaterialInStore { get; set; }
        public double? MassUsingofMaterialeveryday { get; set; }
        public double? MassofAllMaterialInStore { get; set; }
        public double? StoreMaxCapacity { get; set; }
        public string? Doccument { get; set; }
        public string? CategoryUnit { get; set; }
    }
}
