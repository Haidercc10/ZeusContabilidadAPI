using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerCitiBank
    {
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public int ValidarTiposDctos { get; set; }
        public int IdenGercitibank { get; set; }
    }
}
