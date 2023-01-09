using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PhotoIdmatch
    {
        public int PhotoIdmatchId { get; set; }
        public int TypeId { get; set; }
        public int Id { get; set; }
        public int PhotoId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
