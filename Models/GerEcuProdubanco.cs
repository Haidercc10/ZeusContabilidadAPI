using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerEcuProdubanco
    {
        public string Nit { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public int IdenGerecuProdubanco { get; set; }
    }
}
