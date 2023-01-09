using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TestUploadImage
    {
        public int Id { get; set; }
        public byte[]? TestImage { get; set; }
    }
}
