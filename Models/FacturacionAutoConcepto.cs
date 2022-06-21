using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturacionAutoConcepto
    {
        public decimal Iden { get; set; }
        public decimal IdenFacturacion { get; set; }
        public decimal Consecutivo { get; set; }
        public string Cliente { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal ValorUnidad { get; set; }
        public decimal ValorUnidadMoneda { get; set; }
        public decimal TasaCambio { get; set; }
        public decimal SubTotal { get; set; }
        public decimal PorcentajeDcto { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal TotalIva { get; set; }
        public decimal Total { get; set; }
        public int Aplicado { get; set; }
        public string? TipoFactura { get; set; }
        public string? NumeroFactura { get; set; }
        public string? Vencimiento { get; set; }
        public string? Referencia { get; set; }
        public string? Proveedor { get; set; }
        public string Bu { get; set; } = null!;
        public string? CambioIva { get; set; }
        public decimal? VlrIvaOrig { get; set; }
        public decimal? VlrBaseivaMod { get; set; }
        public decimal? VlrBaseivaOrig { get; set; }

        public virtual Cliente ClienteNavigation { get; set; } = null!;
        public virtual Factconc ConceptoNavigation { get; set; } = null!;
        public virtual FacturacionAutoNovedade IdenFacturacionNavigation { get; set; } = null!;
    }
}
