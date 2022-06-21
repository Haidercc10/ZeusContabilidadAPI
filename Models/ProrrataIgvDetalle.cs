using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProrrataIgvDetalle
    {
        public decimal Consecutivo { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Tercero { get; set; } = null!;
        public string? Cenco { get; set; }
        public string? Auxiabto { get; set; }
        public string? Item { get; set; }
        public string? Propiedad1 { get; set; }
        public string? Propiedad2 { get; set; }
        public string? Propiedad3 { get; set; }
        public string? Propiedad4 { get; set; }
        public string? Propiedad5 { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorIgv { get; set; }
        public int IdenProrrataigvDetalle { get; set; }
        public string? CtaGastoProrrata { get; set; }

        public virtual ProrrataIgv ConsecutivoNavigation { get; set; } = null!;
    }
}
