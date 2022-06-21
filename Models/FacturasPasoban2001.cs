using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasPasoban2001
    {
        public string? Tipofact { get; set; }
        public string? Numefac { get; set; }
        public string? Vencfac { get; set; }
        public string? Refefac { get; set; }
        public string? Codicta { get; set; }
        public string? Cliente { get; set; }
        public int? Spid { get; set; }
        public string Bu { get; set; } = null!;
        public int IdenFacturaspasoban2001 { get; set; }
    }
}
