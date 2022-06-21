using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoItauColombium
    {
        public string Cuenta { get; set; } = null!;
        public string NombreCuenta { get; set; } = null!;
        public int IdenGerBancoItauColombia { get; set; }
    }
}
