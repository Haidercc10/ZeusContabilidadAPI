using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciasCuenta
    {
        public decimal Iden { get; set; }
        public int IdenGerencia { get; set; }
        public string TipoCuenta { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public bool Principal { get; set; }

        public virtual Gerencia IdenGerenciaNavigation { get; set; } = null!;
    }
}
