using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VwTransaccionContable
    {
        public string Ano { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public int Consecutivo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Tercero { get; set; } = null!;
        public string? AuxiliarAbierto { get; set; }
        public string? CentroCosto { get; set; }
        public string? Item { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal Valor { get; set; }
        public string? IndicadorPrincipal { get; set; }
        public string? Conciliar { get; set; }
        public string? Banco { get; set; }
        public string? Vendedor { get; set; }
        public string? Plaza { get; set; }
        public string? TipoFactura { get; set; }
        public string? Moneda { get; set; }
        public string? NumeroDocumento { get; set; }
        public DateTime? VencimientoDocumento { get; set; }
        public string? ReferenciaDocumento { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public string? Zona { get; set; }
        public string? Cliente { get; set; }
        public string? Proveedor { get; set; }
        public decimal? PorcentajeRetencion { get; set; }
        public decimal? BaseRetencion { get; set; }
        public string? CodigoPresupuesto { get; set; }
        public string? NumeroReserva { get; set; }
        public decimal? ValorMoneda { get; set; }
        public string? Estado { get; set; }
        public int? ConsecutivoRevision { get; set; }
        public string? Serie { get; set; }
        public string? Autorizacion { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string? Adicional1 { get; set; }
        public string? Adicional2 { get; set; }
        public string Voucher { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public string UnidadNegocio { get; set; } = null!;
        public string? Ncf { get; set; }
        public string? NcfModificado { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        public decimal BaseComision { get; set; }
        public int? ConsecutivoTransaccionEsquema { get; set; }
        public string? GeneraEsquema { get; set; }
        public decimal? Esquema { get; set; }
        public int? AplicacionesOrigen { get; set; }
        public decimal? ValorMoneda1 { get; set; }
        public decimal? ValorMoneda2 { get; set; }
        public decimal? TasaCambio1 { get; set; }
        public decimal? TasaCambio2 { get; set; }
        public int MovimientoPorConsolidacion { get; set; }
        public string? Propiedad1 { get; set; }
        public string? Propiedad2 { get; set; }
        public string? Propiedad3 { get; set; }
        public string? Propiedad4 { get; set; }
        public string? Propiedad5 { get; set; }
        public bool? FacturaMovimientoOriginal { get; set; }
        public int? AplicacionesZeus { get; set; }
        public int? OrigenMovimiento { get; set; }
        public int? ConsecutivoTransaccionRelacionado { get; set; }
        public string? Movimiento { get; set; }
        public string? LineaImpuesto { get; set; }
        public string? SubLineaImpuesto { get; set; }
        public string? ComponenteRetencionSerie { get; set; }
        public string? ComponenteRetencionSecuencial { get; set; }
        public DateTime? ComponenteRetencionFechaEmision { get; set; }
        public string? ComponenteRetencionAutorizacion { get; set; }
        public string? XmlAdicionales { get; set; }
        public string? MonedaRelacion { get; set; }
        public decimal? ValorMonedaRelacion { get; set; }
        public double? TasaCambioMonedaRelacion { get; set; }
        public int? ConsecutivoTransaccionMonedaRelacion { get; set; }
        public string? ReferenciaPorTransaccion { get; set; }
        public string? UsuarioRecepcion { get; set; }
    }
}
