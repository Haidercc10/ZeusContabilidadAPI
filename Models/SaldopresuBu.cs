using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SaldopresuBu
    {
        public string Bu { get; set; } = null!;
        public string Codipresu { get; set; } = null!;
        public string Codcco { get; set; } = null!;
        public string Anomescta { get; set; } = null!;
        public decimal? Valorpresu { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Mcredito { get; set; }
        public decimal? Mdebito { get; set; }
        public decimal? Trasladodb { get; set; }
        public decimal? Trasladocr { get; set; }
        public decimal? Adiciones { get; set; }
        public decimal? Disminuciones { get; set; }
        public int IdenSaldopresuBu { get; set; }
    }
}
