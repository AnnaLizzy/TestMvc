using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MaterialforChemistry
    {
        public int Id { get; set; }
        public int ChemistryFormId { get; set; }
        public string? MaterialId { get; set; }
        public string? MaterialName { get; set; }
        public string FireTemp { get; set; } = null!;
        public string? Mass { get; set; }
        public string? Amount { get; set; }
        public string? TotalMass { get; set; }
        public string? MassofMaterialInStore { get; set; }
        public string? MassUsingofMaterialeveryday { get; set; }
        public string? MassofAllMaterialInStore { get; set; }
        public string? StoreMaxCapacity { get; set; }
        public string? Doccument { get; set; }
        public string? CategoryUnit { get; set; }
    }
}
