using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MesesLibro
    {
        public string? Periodo { get; set; }
        public decimal? IdenLibro { get; set; }
        public bool? PermitirMovimiento { get; set; }
        public int IdenMesesLibro { get; set; }
    }
}
