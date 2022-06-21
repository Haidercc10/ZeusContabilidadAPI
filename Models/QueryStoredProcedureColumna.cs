using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryStoredProcedureColumna
    {
        public decimal IdenColumna { get; set; }
        public string? StoredProcedure { get; set; }
        public string? Columna { get; set; }
        public bool? Mostrar { get; set; }
        public int? Orden { get; set; }
        public string? TipoOrden { get; set; }
        public string? FuncionGrupo { get; set; }

        public virtual QueryPropiedadesStoredProcedure? StoredProcedureNavigation { get; set; }
    }
}
