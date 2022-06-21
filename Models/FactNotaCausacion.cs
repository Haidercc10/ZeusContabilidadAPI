using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactNotaCausacion
    {
        public FactNotaCausacion()
        {
            FactRelacionCausacions = new HashSet<FactRelacionCausacion>();
        }

        public int Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public decimal ConsecutivoRelacionado { get; set; }
        public string CuentaOrden { get; set; } = null!;
        public string? CuentaIva { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal VrConcepto { get; set; }
        public decimal VrIva { get; set; }
        public decimal VrTotalConcepto { get; set; }
        public decimal VrCausadoConcepto { get; set; }
        public decimal VrCausadoIva { get; set; }
        public decimal VrTotalCausado { get; set; }
        public decimal SaldoConcepto { get; set; }
        public decimal SaldoIva { get; set; }
        public decimal SaldoTotalConcepto { get; set; }
        public string? CodigoPropiedad1 { get; set; }
        public string? CodigoPropiedad2 { get; set; }
        public string? CodigoPropiedad3 { get; set; }
        public string? CodigoPropiedad4 { get; set; }
        public string? CodigoPropiedad5 { get; set; }

        public virtual Factconc ConceptoNavigation { get; set; } = null!;
        public virtual Maecont? CuentaIvaNavigation { get; set; }
        public virtual Maecont CuentaOrdenNavigation { get; set; } = null!;
        public virtual Document Document { get; set; } = null!;
        public virtual ICollection<FactRelacionCausacion> FactRelacionCausacions { get; set; }
    }
}
