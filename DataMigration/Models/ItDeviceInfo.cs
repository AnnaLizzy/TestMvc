using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ItDeviceInfo
    {
        public int? ItDeviceId { get; set; }
        public string? DeviceType { get; set; }
        public string? AssetType { get; set; }
        public string? Brand { get; set; }
        public string? Specifications { get; set; }
        public string? Color { get; set; }
        public string? Sn { get; set; }
        public int? HaveWifi { get; set; }
        public string? ProductId { get; set; }
        public string? Picture { get; set; }
        public string? Notes { get; set; }
    }
}
