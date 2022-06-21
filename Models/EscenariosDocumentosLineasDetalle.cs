using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosDocumentosLineasDetalle
    {
        public decimal Iden { get; set; }
        public decimal EscenariosDocumentosLineas { get; set; }
        public string SubLinea { get; set; } = null!;
        public string? ImpuestoRetencion { get; set; }
        public decimal? EscenariosImpuestosIden { get; set; }
        public string? TipoImpuesto { get; set; }
        public string? TipoAplicacionImpuestoIden { get; set; }
        public bool? ImpuestoPagado { get; set; }
        public decimal? Porcentaje { get; set; }
        public int? Redondeo { get; set; }
        public decimal? EscenariosRetencionesIden { get; set; }
        public string? EscenariosTipoTasaIden { get; set; }
        public string? EscenariosConceptoRetencionIden { get; set; }
        public decimal? BaseMoneda { get; set; }
        public decimal? Base { get; set; }
        public decimal? PorcentajeDeLaBase { get; set; }
        public string? Naturaleza { get; set; }
        public string? CuentaMovimientoDb { get; set; }
        public string? CuentaMovimientoCr { get; set; }
        public decimal? TotalDb { get; set; }
        public decimal? TotalCr { get; set; }
        public decimal? TotalAsumido { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalMonedaDb { get; set; }
        public decimal? TotalMonedaCr { get; set; }
        public decimal? TotalMonedaAsumido { get; set; }
        public decimal? TotalMoneda { get; set; }
        public bool? Interfaz { get; set; }
        public string? Observacion { get; set; }

        public virtual EscenariosImpuesto? EscenariosImpuestosIdenNavigation { get; set; }
        public virtual EscenariosRetencione? EscenariosRetencionesIdenNavigation { get; set; }
    }
}
