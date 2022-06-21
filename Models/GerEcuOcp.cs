using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerEcuOcp
    {
        public string Nit { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoNuc { get; set; } = null!;
        public int IdenGerecuOcp { get; set; }
    }
}
