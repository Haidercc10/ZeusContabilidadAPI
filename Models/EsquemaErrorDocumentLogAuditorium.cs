using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaErrorDocumentLogAuditorium
    {
        public int Iden { get; set; }
        public int IdenEsquemaErrorDocument { get; set; }
        public int Descartado { get; set; }
        public int Revisado { get; set; }
        public string UsuarioAuditoria { get; set; } = null!;
        public DateTime FechaAuditoria { get; set; }
        public string? DescripcionAuditoria { get; set; }

        public virtual EsquemaErrorDocument IdenEsquemaErrorDocumentNavigation { get; set; } = null!;
    }
}
