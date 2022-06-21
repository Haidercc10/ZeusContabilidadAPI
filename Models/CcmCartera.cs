using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmCartera
    {
        public string CodigoCliente { get; set; } = null!;
        public string CodigoTercero { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public decimal SaldoInicial { get; set; }
        public decimal Abonos { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }
    }
}
