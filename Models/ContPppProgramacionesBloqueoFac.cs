using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppProgramacionesBloqueoFac
    {
        public decimal Id { get; set; }
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofact { get; set; } = null!;
        public string? Numefac { get; set; }
        public string? Vencfac { get; set; }
        public string? Refefac { get; set; }
    }
}
