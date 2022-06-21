using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReferenciaPorTransaccionCuentum
    {
        public int Iden { get; set; }
        public string CodiCta { get; set; } = null!;
        public string Formula { get; set; } = null!;
        public string? ExcluTercero { get; set; }
    }
}
