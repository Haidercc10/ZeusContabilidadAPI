using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SriImpuesto
    {
        public decimal Iden { get; set; }
        public string? Codigo { get; set; }
        public string? CodigoRetencion { get; set; }
        public decimal? BaseImponible { get; set; }
        public decimal? PorcentajeRetener { get; set; }
        public decimal? ValorRetenido { get; set; }
        public string? CodDocSustento { get; set; }
        public string? NumDocSustento { get; set; }
        public string? CuentaConcepto { get; set; }
        public string? ClaveAcceso { get; set; }
        public string? ClienteProveedor { get; set; }
        public string? CuentaCartera { get; set; }
        public string? FechaFactura { get; set; }
        public string? TipoFactura { get; set; }
        public string? NumeroFactura { get; set; }
        public string? Vencimiento { get; set; }
        public string? Referencia { get; set; }
        public string? UnidadDeNegocio { get; set; }
        public string? Vendedor { get; set; }
        public decimal IdenXmlRecibido { get; set; }
    }
}
