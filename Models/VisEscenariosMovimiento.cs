using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VisEscenariosMovimiento
    {
        public DateTime Fecha { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string Tercero { get; set; } = null!;
        public string? TerceroNombre { get; set; }
        public string? Pais { get; set; }
        public string? PaisNombre { get; set; }
        public string Moneda { get; set; } = null!;
        public string? MonedaNombre { get; set; }
        public decimal TasaCambio { get; set; }
        public string Modulo { get; set; } = null!;
        public string TipoOperacion { get; set; } = null!;
        public decimal? DocumentosTotalBruto { get; set; }
        public decimal? DocumentosTotalIva { get; set; }
        public decimal? DocumentosTotalInc { get; set; }
        public decimal? DocumentosTotalRetencion { get; set; }
        public string? Linea { get; set; }
        public string? SubLinea { get; set; }
        public string? ImpuestoRetencion { get; set; }
        public string? TipoImpuesto { get; set; }
        public int? MayorValor { get; set; }
        public string? Impuesto { get; set; }
        public string? ImpuestoNombre { get; set; }
        public string? Iva1Iva2 { get; set; }
        public string? Retencion { get; set; }
        public string? RetencionNombre { get; set; }
        public string? ImpuestoRetencionCuenta { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? ImpuestoRetencionValor { get; set; }
        public decimal? ImpuestoRetencionBase { get; set; }
        public string? TipoTasa { get; set; }
        public string? ConceptoRetencion { get; set; }
        public string Codigo1 { get; set; } = null!;
        public string Codigo2 { get; set; } = null!;
        public string? Detalle { get; set; }
        public string? LineaCuentaMovimiento { get; set; }
        public string? CategoriaTributaria { get; set; }
        public string? CategoriaTributariaNombre { get; set; }
        public string? TributarioConsumo { get; set; }
        public string? TributarioConsumoNombre { get; set; }
        public string? TributarioRenta { get; set; }
        public string? TributarioRentaNombre { get; set; }
        public string? SubCategoriaEfecCompra { get; set; }
        public string? SubCategoriaEfecCompraNombre { get; set; }
        public string? Escenario { get; set; }
        public string? EscenarioNombre { get; set; }
        public string? TributarioIcat { get; set; }
        public string? TributarioIcatnombre { get; set; }
        public string? Ciudad { get; set; }
        public string? CiudadNombre { get; set; }
        public decimal? PorcentajeIva { get; set; }
        public decimal? PorcentajeInc { get; set; }
        public decimal? LineaTotalIva { get; set; }
        public decimal? LineaTotalInc { get; set; }
        public decimal? LineaTotalRetencion { get; set; }
        public decimal? CiudadIden { get; set; }
    }
}
