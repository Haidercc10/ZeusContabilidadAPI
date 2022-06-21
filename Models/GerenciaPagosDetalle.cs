using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaPagosDetalle
    {
        public int? IdenGerencia { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Tercero { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Banco { get; set; } = null!;
        public decimal Valor { get; set; }
        public decimal ValorMoneda { get; set; }
        public int IdenGerenciapagosdetalle { get; set; }

        public virtual Gerencia? IdenGerenciaNavigation { get; set; }
    }
}
