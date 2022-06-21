using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryPropiedadesParametro
    {
        public string StoredProcedure { get; set; } = null!;
        public string Parametro { get; set; } = null!;
        public string? DescripcionParametro { get; set; }
        public bool? ActivarAyuda { get; set; }
        public string? SeccionAyuda { get; set; }
        public string? OpcionalAyuda { get; set; }
        public string? ListaPosibilidades { get; set; }
        public string? ExpresionTipoDato { get; set; }
        public string? ExpresionFiltro { get; set; }
        public decimal OrdenGrabacion { get; set; }
        public string? Columna { get; set; }
        public string? Operacion { get; set; }
        public string? ParentisisApertura { get; set; }
        public string? ParentisisCierre { get; set; }
        public bool Requerido { get; set; }

        public virtual QueryPropiedadesStoredProcedure StoredProcedureNavigation { get; set; } = null!;
    }
}
