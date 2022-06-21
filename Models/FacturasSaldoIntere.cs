using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasSaldoIntere
    {
        public string IdFuente { get; set; } = null!;
        public string Numdoctra { get; set; } = null!;
        public string CliPrv { get; set; } = null!;
        public decimal TasaInteres { get; set; }
        public decimal SaldoVencido { get; set; }
        public decimal Mora { get; set; }
        public decimal SaldoVencidoM { get; set; }
        public decimal MoraM { get; set; }
        public int IdenFacturasSaldointeres { get; set; }
    }
}
