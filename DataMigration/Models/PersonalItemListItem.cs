using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PersonalItemListItem
    {
        public int Id { get; set; }
        public int PersonItemsFormId { get; set; }
        public string? ItemsName { get; set; }
        public int? Amount { get; set; }
        public string? Reason { get; set; }
    }
}
