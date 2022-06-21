using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VfacturasProgramacion
    {
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofact { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencfac { get; set; } = null!;
        public string? Refefac { get; set; }
        public decimal? Valprog { get; set; }
        public decimal? ValorMoneda { get; set; }
        public string Bu { get; set; } = null!;
    }
}
