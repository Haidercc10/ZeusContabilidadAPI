using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerEcuMulticash
    {
        public string Nit { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public int IdenGerecuMulticash { get; set; }
    }
}
