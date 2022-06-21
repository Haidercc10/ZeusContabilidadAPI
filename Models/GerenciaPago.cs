using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaPago
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
        public int Impreso { get; set; }
        public int ArchivoGerencia { get; set; }
        public int EgresoConsolidado { get; set; }
        public string Estado { get; set; } = null!;
        public string IndFormaPago { get; set; } = null!;
        public long IdenGerenciaPagos { get; set; }
        public decimal ConsecutivoArchivo { get; set; }

        public virtual Gerencia? IdenGerenciaNavigation { get; set; }
    }
}
