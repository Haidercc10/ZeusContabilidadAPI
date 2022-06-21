using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasProgramacion
    {
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofact { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencfac { get; set; } = null!;
        public string? Refefac { get; set; }
        public string Fecprog { get; set; } = null!;
        public decimal? Valprog { get; set; }
        public string Estado { get; set; } = null!;
        public decimal ValorMoneda { get; set; }
        public decimal SaldoFact { get; set; }
        public decimal SaldoFactMon { get; set; }
        public string Bu { get; set; } = null!;
        public decimal? ValorIntCorriente { get; set; }
        public int IdenFacturasProgramacion { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
    }
}
