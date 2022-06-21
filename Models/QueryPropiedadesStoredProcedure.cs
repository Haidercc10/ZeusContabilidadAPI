using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryPropiedadesStoredProcedure
    {
        public QueryPropiedadesStoredProcedure()
        {
            QueryPropiedadesParametros = new HashSet<QueryPropiedadesParametro>();
            QueryStoredProcedureColumnas = new HashSet<QueryStoredProcedureColumna>();
        }

        public string StoredProcedure { get; set; } = null!;
        public string? DescripcionProcedure { get; set; }
        public string? NombreReporte { get; set; }
        public decimal? IdenEntornoDatos { get; set; }
        public decimal? Usuario { get; set; }
        public string? Categoria { get; set; }
        public int IdenQuerypropiedadesstoredprocedure { get; set; }

        public virtual QueryEntornoDato? IdenEntornoDatosNavigation { get; set; }
        public virtual ICollection<QueryPropiedadesParametro> QueryPropiedadesParametros { get; set; }
        public virtual ICollection<QueryStoredProcedureColumna> QueryStoredProcedureColumnas { get; set; }
    }
}
