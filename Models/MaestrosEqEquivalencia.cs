using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaestrosEqEquivalencia
    {
        public string TipoMaestro { get; set; } = null!;
        public string CodigoMaestro { get; set; } = null!;
        public string? Valor { get; set; }
        public int IdenMaestroseqEquivalencias { get; set; }
    }
}
