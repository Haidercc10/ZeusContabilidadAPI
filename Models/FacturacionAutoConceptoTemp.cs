using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturacionAutoConceptoTemp
    {
        public decimal Iden { get; set; }
        public decimal SpId { get; set; }
        public string? Cliente { get; set; }
        public string? Concepto { get; set; }
        public string? Descripcion { get; set; }
        public string Documento { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? ValorUnidad { get; set; }
        public decimal? ValorUnidadMoneda { get; set; }
        public decimal? PorcentajeDcto { get; set; }
        public decimal? PorcentajeIva { get; set; }
        public decimal? TasaCambio { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TotalDescuento { get; set; }
        public decimal? TotalIva { get; set; }
        public decimal? Total { get; set; }
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
    }
}
