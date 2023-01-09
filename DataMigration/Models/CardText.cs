using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardText
    {
        public int CardTextId { get; set; }
        public string? TextName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
