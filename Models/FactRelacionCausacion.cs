using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactRelacionCausacion
    {
        public int Iden { get; set; }
        public int IdenRelacionado { get; set; }
        public string FuenteRc { get; set; } = null!;
        public string DocumentoRc { get; set; } = null!;
        public string EstadoRc { get; set; } = null!;
        public string FuenteFa { get; set; } = null!;
        public string DocumentoFa { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public decimal VrCausadoConcepto { get; set; }
        public decimal VrCausadoIva { get; set; }
        public decimal VrTotalCausado { get; set; }

        public virtual Factconc ConceptoNavigation { get; set; } = null!;
        public virtual Document Document { get; set; } = null!;
        public virtual Document DocumentNavigation { get; set; } = null!;
        public virtual FactNotaCausacion IdenRelacionadoNavigation { get; set; } = null!;
    }
}
