using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryEntornoDatosColumna
    {
        public decimal IdenColumna { get; set; }
        public decimal? IdenEntornoDatos { get; set; }
        public string? Columna { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoDato { get; set; }
        public string? ExpresionTipoDato { get; set; }
        public bool EsVariable { get; set; }
        public string? FuncionVariable { get; set; }

        public virtual QueryEntornoDato? IdenEntornoDatosNavigation { get; set; }
    }
}
