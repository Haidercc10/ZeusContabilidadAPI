using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RelacionConciliacionNotum
    {
        public decimal Iden { get; set; }
        public string IdFuente { get; set; } = null!;
        public string Numdoctra { get; set; } = null!;
        public decimal Consecutra { get; set; }
    }
}
