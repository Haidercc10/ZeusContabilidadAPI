using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwQueryPropiedadesParametro
    {
        public decimal IdQueryPropiedadesParametros { get; set; }
        public decimal IdQueryPropiedadesStoredProcedure { get; set; }
        public string NmParametro { get; set; } = null!;
        public string? DsDescripcionParametro { get; set; }
        public bool? BtActivarAyuda { get; set; }
        public string? DsSeccionAyuda { get; set; }
        public string? DsOpcionalAyuda { get; set; }
        public string? DsListaPosibilidades { get; set; }
        public string? DsExpresionTipoDato { get; set; }
        public string? DsExpresionFiltro { get; set; }
        public decimal? InOrdenGrabacion { get; set; }
        public string? DsColumna { get; set; }
        public string? DsOperacion { get; set; }
        public string? DsParentisisApertura { get; set; }
        public string? DsParentisisCierre { get; set; }

        public virtual ZeusFwQueryPropiedadesStoredProcedure IdQueryPropiedadesStoredProcedureNavigation { get; set; } = null!;
    }
}
