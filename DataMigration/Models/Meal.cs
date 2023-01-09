using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Meal
    {
        public int MealId { get; set; }
        public int? VisitCustId { get; set; }
        public DateTime? DiningTime { get; set; }
        public string? MealLeavel { get; set; }
        public string? MealAddress { get; set; }
        public int? MealCustNum { get; set; }
        public string? AccompanyManagers { get; set; }
        public string? AccompanyManagers1 { get; set; }
        public string? AccompanyManagers2 { get; set; }
        public int? MealNum { get; set; }
    }
}
