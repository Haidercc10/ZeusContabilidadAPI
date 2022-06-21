using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VisEscenariosDocumentosLinea
    {
        public string? Linea { get; set; }
        public string? TipoLinea { get; set; }
        public string? Codigo1 { get; set; }
        public string? Codigo2 { get; set; }
        public string? CuentaMovimiento { get; set; }
        public decimal? EscenariosTributarioConsumoIden { get; set; }
        public decimal? EscenariosTributarioRentaIden { get; set; }
        public decimal? EscenariosSubCategoriaEfecCompraIden { get; set; }
        public decimal? EscenariosTributarioIcatIden { get; set; }
        public decimal? EscenariosEscenarioIden { get; set; }
        public decimal? Ciudad { get; set; }
        public decimal? TotalBrutoMoneda { get; set; }
        public decimal? PorcentajeIva { get; set; }
        public decimal? PorcentajeInc { get; set; }
        public decimal? EscenariosImpuestosIden1 { get; set; }
        public decimal? EscenariosImpuestosIden2 { get; set; }
        public decimal? EscenariosImpuestosIden3 { get; set; }
        public decimal? EscenariosImpuestosIden4 { get; set; }
        public decimal? EscenariosImpuestosIden5 { get; set; }
        public decimal? ValorImpuesto1 { get; set; }
        public decimal? ValorImpuesto2 { get; set; }
        public decimal? ValorImpuesto3 { get; set; }
        public decimal? ValorImpuesto4 { get; set; }
        public decimal? ValorImpuesto5 { get; set; }
        public string? Detalle { get; set; }
    }
}
