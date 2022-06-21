using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AsobancariaFactura
    {
        public decimal Iden { get; set; }
        public decimal? Consecutivo { get; set; }
        public string? Bu { get; set; }
        public string? CodiCta { get; set; }
        public string? IdCliPrv { get; set; }
        public string? TipoFact { get; set; }
        public string? NumeFac { get; set; }
        public string? VencFac { get; set; }
        public string? RefeFac { get; set; }
        public decimal? SaldoActual { get; set; }
        public string? IdTercero { get; set; }
        public decimal? ValorApagar { get; set; }
        public decimal? IdenResumen { get; set; }
    }
}
