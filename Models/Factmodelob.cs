using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factmodelob
    {
        public string Codigo { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public decimal Orden { get; set; }
        public decimal? PorceivaFco { get; set; }
        public string? CodigoivaFco { get; set; }

        public virtual Factmodeloh CodigoNavigation { get; set; } = null!;
        public virtual Factconc ConceptoNavigation { get; set; } = null!;
    }
}
