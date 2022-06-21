using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryEntornoDato
    {
        public QueryEntornoDato()
        {
            QueryEntornoDatosColumnas = new HashSet<QueryEntornoDatosColumna>();
            QueryPropiedadesStoredProcedures = new HashSet<QueryPropiedadesStoredProcedure>();
        }

        public decimal Iden { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Sqlrelaciones { get; set; }
        public string? CampoTipoDocumento { get; set; }
        public string? CampoConsecutivo { get; set; }
        public string? CampoTipoTransaccion { get; set; }
        public string? CampoIdTransaccion { get; set; }

        public virtual ICollection<QueryEntornoDatosColumna> QueryEntornoDatosColumnas { get; set; }
        public virtual ICollection<QueryPropiedadesStoredProcedure> QueryPropiedadesStoredProcedures { get; set; }
    }
}
