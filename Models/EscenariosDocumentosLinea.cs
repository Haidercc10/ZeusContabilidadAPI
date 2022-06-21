using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosDocumentosLinea
    {
        public decimal Iden { get; set; }
        public decimal EscenariosDocumentosIden { get; set; }
        public string Linea { get; set; } = null!;
        public string TipoLinea { get; set; } = null!;
        public string Codigo1 { get; set; } = null!;
        public string Codigo2 { get; set; } = null!;
        public string? CuentaMovimiento { get; set; }
        public string? EscenariosCategoriaTributariaIden { get; set; }
        public decimal? EscenariosTributarioConsumoIden { get; set; }
        public decimal? EscenariosTributarioRentaIden { get; set; }
        public decimal? EscenariosSubCategoriaEfecCompraIden { get; set; }
        public decimal? EscenariosEscenarioIden { get; set; }
        public decimal? EscenariosTributarioIcatIden { get; set; }
        public decimal? EscenariosFiscalesIden { get; set; }
        public decimal? Ciudad { get; set; }
        public decimal? TotalBruto { get; set; }
        public decimal? PorcentajeIva { get; set; }
        public decimal? PorcentajeInc { get; set; }
        public decimal? TotalIvadb { get; set; }
        public decimal? TotalIvacr { get; set; }
        public decimal? TotalIvaasumido { get; set; }
        public decimal? TotalIva { get; set; }
        public decimal? TotalIncdb { get; set; }
        public decimal? TotalInccr { get; set; }
        public decimal? TotalIncasumido { get; set; }
        public decimal? TotalInc { get; set; }
        public decimal? TotalRetencionDb { get; set; }
        public decimal? TotalRetencionCr { get; set; }
        public decimal? TotalRetencion { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalBrutoMoneda { get; set; }
        public decimal? TotalIvadbmoneda { get; set; }
        public decimal? TotalIvacrmoneda { get; set; }
        public decimal? TotalIvaasumidoMoneda { get; set; }
        public decimal? TotalIvamoneda { get; set; }
        public decimal? TotalIncdbmoneda { get; set; }
        public decimal? TotalInccrmoneda { get; set; }
        public decimal? TotalIncasumidoMoneda { get; set; }
        public decimal? TotalIncmoneda { get; set; }
        public decimal? TotalRetencionDbmoneda { get; set; }
        public decimal? TotalRetencionCrmoneda { get; set; }
        public decimal? TotalRetencionMoneda { get; set; }
        public decimal? TotalMoneda { get; set; }
        public decimal? MaxIvadescontable { get; set; }
        public decimal? MaxIncdescontable { get; set; }
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
        public string? Modo { get; set; }
        public decimal? Cantidad { get; set; }

        public virtual EscenariosCiudad? CiudadNavigation { get; set; }
        public virtual EscenariosCategoriaTributarium? EscenariosCategoriaTributariaIdenNavigation { get; set; }
        public virtual EscenariosEscenario? EscenariosEscenarioIdenNavigation { get; set; }
        public virtual EscenariosImpuesto? EscenariosImpuestosIden1Navigation { get; set; }
        public virtual EscenariosImpuesto? EscenariosImpuestosIden2Navigation { get; set; }
        public virtual EscenariosImpuesto? EscenariosImpuestosIden3Navigation { get; set; }
        public virtual EscenariosImpuesto? EscenariosImpuestosIden4Navigation { get; set; }
        public virtual EscenariosImpuesto? EscenariosImpuestosIden5Navigation { get; set; }
        public virtual EscenariosSubCategoriaEfecCompra? EscenariosSubCategoriaEfecCompraIdenNavigation { get; set; }
        public virtual EscenariosTributarioConsumo? EscenariosTributarioConsumoIdenNavigation { get; set; }
        public virtual EscenariosTributarioIcat? EscenariosTributarioIcatIdenNavigation { get; set; }
        public virtual EscenariosTributarioRentum? EscenariosTributarioRentaIdenNavigation { get; set; }
    }
}
