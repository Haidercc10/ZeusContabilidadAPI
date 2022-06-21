using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfactAutoConceptoTemp
    {
        public decimal Iden { get; set; }
        public decimal SpId { get; set; }
        public string? Proveedor { get; set; }
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
    }
}
