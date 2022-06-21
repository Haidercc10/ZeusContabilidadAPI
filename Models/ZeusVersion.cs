using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusVersion
    {
        public decimal Id { get; set; }
        public string? Version { get; set; }
        public int? Revision { get; set; }
    }
}
