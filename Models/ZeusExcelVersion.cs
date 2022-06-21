using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelVersion
    {
        public int Iden { get; set; }
        public string? DsVersion { get; set; }
        public string? DsRevision { get; set; }
    }
}
