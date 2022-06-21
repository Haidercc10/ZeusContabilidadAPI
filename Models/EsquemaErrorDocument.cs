using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaErrorDocument
    {
        public EsquemaErrorDocument()
        {
            EsquemaErrorDocumentLogAuditoria = new HashSet<EsquemaErrorDocumentLogAuditorium>();
        }

        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaProceso { get; set; }
        public string ErroresContables { get; set; } = null!;
        public int Iden { get; set; }
        public int Descartado { get; set; }
        public int Revisado { get; set; }
        public string? UsuarioAuditoria { get; set; }
        public DateTime? FechaAuditoria { get; set; }
        public string? DescripcionAuditoria { get; set; }

        public virtual ICollection<EsquemaErrorDocumentLogAuditorium> EsquemaErrorDocumentLogAuditoria { get; set; }
    }
}
