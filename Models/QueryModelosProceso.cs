using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryModelosProceso
    {
        public QueryModelosProceso()
        {
            QueryModelosProcesoArchivos = new HashSet<QueryModelosProcesoArchivo>();
        }

        public decimal Iden { get; set; }
        public string CodigoModelo { get; set; } = null!;
        public string RutaArchivos { get; set; } = null!;
        public DateTime FechaProceso { get; set; }

        public virtual QueryModelo CodigoModeloNavigation { get; set; } = null!;
        public virtual ICollection<QueryModelosProcesoArchivo> QueryModelosProcesoArchivos { get; set; }
    }
}
