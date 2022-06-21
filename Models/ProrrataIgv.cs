using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProrrataIgv
    {
        public decimal Consecutivo { get; set; }
        public string Bu { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string FechaIni { get; set; } = null!;
        public string FechaFin { get; set; } = null!;
        public string FechaProceso { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public decimal? PorceRateo { get; set; }
        public string? Item { get; set; }
    }
}
