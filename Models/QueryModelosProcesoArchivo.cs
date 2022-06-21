using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryModelosProcesoArchivo
    {
        public decimal IdenModeloProceso { get; set; }
        public decimal Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public int Generado { get; set; }
        public int Email { get; set; }
        public string EmailTo { get; set; } = null!;
        public string EmailSubject { get; set; } = null!;
        public string EmailObject { get; set; } = null!;
        public string MensajeError { get; set; } = null!;
        public DateTime? FechaEnvio { get; set; }

        public virtual QueryModelosProceso IdenModeloProcesoNavigation { get; set; } = null!;
    }
}
