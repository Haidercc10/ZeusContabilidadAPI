using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TsunatComprasLog
    {
        public string? IdenTerceros { get; set; }
        public string? Compañia { get; set; }
        public string? NitCompañia { get; set; }
        public string? IdenImpuesto { get; set; }
        public string? NoBoleta { get; set; }
        public string? FechaPresentacion { get; set; }
        public string? Fecha { get; set; }
        public string? Vencimiento { get; set; }
        public string? TipoFactura { get; set; }
        public string? Numerofactura { get; set; }
        public string? CodigoTercero { get; set; }
        public string? NombreTercero { get; set; }
        public decimal? SumConceptosIva { get; set; }
        public decimal? SumConceptossinIva { get; set; }
        public decimal? VrIva { get; set; }
        public decimal? OtrosConceptos { get; set; }
        public decimal? AsumConceptosIva { get; set; }
        public decimal? AsumConceptosSinIva { get; set; }
        public decimal? AvrIva { get; set; }
        public decimal? AotrosConceptos { get; set; }
        public decimal? BsumConceptosIva { get; set; }
        public decimal? BsumConceptosSinIva { get; set; }
        public decimal? BvrIva { get; set; }
        public decimal? BotrosConceptos { get; set; }
        public decimal? CsumConceptosIva { get; set; }
        public decimal? CsumConceptosSinIva { get; set; }
        public decimal? CvrIva { get; set; }
        public decimal? CotrosConceptos { get; set; }
        public decimal? EsumConceptosIva { get; set; }
        public decimal? EsumConceptosSinIva { get; set; }
        public decimal? EvrIva { get; set; }
        public decimal? EotrosConceptos { get; set; }
        public string? FechaDeposito { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? Serie { get; set; }
        public string? NombreProveedor { get; set; }
        public string? FacturaReferencia { get; set; }
        public string? CodigoDua { get; set; }
        public string? AnoDua { get; set; }
        public string? NoDua { get; set; }
        public string? TipoDctoFhe { get; set; }
        public string? TipoId { get; set; }
        public string? Destino { get; set; }
        public decimal? Tcambio { get; set; }
        public string? ComprobanteNd { get; set; }
        public string? DocDetraccion { get; set; }
        public string? FechaDetraccion { get; set; }
        public int? IdAplicacion { get; set; }
        public string? Moneda { get; set; }
        public string? ConsecutivoInterno { get; set; }
        public string? BodegaAmbiente { get; set; }
        public decimal Idregistro { get; set; }
        public int EstadoRegistro { get; set; }
        public string FechaReporte { get; set; } = null!;
        public int FormaPago { get; set; }
        public string TipoCompra { get; set; } = null!;
        public string TipoPersona { get; set; } = null!;
        public string Apellido1 { get; set; } = null!;
        public string Apellido2 { get; set; } = null!;
        public string Nombre1 { get; set; } = null!;
        public string Nombre2 { get; set; } = null!;
        public string TipoMoneda { get; set; } = null!;
        public string CodigoDestino { get; set; } = null!;
        public string NumeroDestino { get; set; } = null!;
        public string IndicadorDetraccion { get; set; } = null!;
        public string CodigoDetraccion { get; set; } = null!;
        public string IndicadorRetencion { get; set; } = null!;
        public decimal BaseReferencia { get; set; }
        public decimal Igvreferencia { get; set; }
        public decimal Isc { get; set; }
        public string? Usuario { get; set; }
        public string Host { get; set; } = null!;
        public DateTime? FechaEvento { get; set; }
        public string Observaciones { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public int? Indicador { get; set; }
    }
}
