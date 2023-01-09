using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PersonalItemImage
    {
        public int Id { get; set; }
        public int? PersionalId { get; set; }
        public string? Image { get; set; }
    }
}
