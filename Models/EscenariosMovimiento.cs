using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosMovimiento
    {
        public decimal Iden { get; set; }
        public decimal? EscenariosDocumentosIden { get; set; }
        public string? Linea { get; set; }
        public string? SubLinea { get; set; }
        public string? ImpuestoRetencion { get; set; }
        public string? TipoImpuesto { get; set; }
        public int? MayorValor { get; set; }
        public decimal? EscenariosImpuestosIden { get; set; }
        public decimal? EscenariosRetencionesIden { get; set; }
        public string? EscenariosTipoTasaIden { get; set; }
        public string? EscenariosConceptoRetencionIden { get; set; }
        public string? Cuenta { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Base { get; set; }
        public decimal? ValorMoneda { get; set; }
        public decimal? BaseMoneda { get; set; }

        public virtual EscenariosImpuesto? EscenariosImpuestosIdenNavigation { get; set; }
        public virtual EscenariosRetencione? EscenariosRetencionesIdenNavigation { get; set; }
    }
}
