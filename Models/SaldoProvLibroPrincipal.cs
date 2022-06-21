using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SaldoProvLibroPrincipal
    {
        public string Codicta { get; set; } = null!;
        public string Idunidad { get; set; } = null!;
        public string Anomescta { get; set; } = null!;
        public string Idprove { get; set; } = null!;
        public decimal? Sdancta { get; set; }
        public decimal? Mvdbcta { get; set; }
        public decimal? Mvcrcta { get; set; }
        public decimal? Sdaccta { get; set; }
        public decimal? Sdanmcta { get; set; }
        public decimal? Mvdbmcta { get; set; }
        public decimal? Mvcrmcta { get; set; }
        public decimal? Sdacmcta { get; set; }
    }
}
