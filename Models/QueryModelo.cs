using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryModelo
    {
        public QueryModelo()
        {
            QueryModelosProcesos = new HashSet<QueryModelosProceso>();
        }

        public string Codigo { get; set; } = null!;
        public string QueryEspecial { get; set; } = null!;
        public string QuerySecuencia { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool? EnvioEmail { get; set; }
        public string EmailTo { get; set; } = null!;
        public string EmailSubject { get; set; } = null!;
        public string EmailBody { get; set; } = null!;
        public string EmailNombreAdjunto { get; set; } = null!;
        public int IdenQuerymodelos { get; set; }

        public virtual ICollection<QueryModelosProceso> QueryModelosProcesos { get; set; }
    }
}
