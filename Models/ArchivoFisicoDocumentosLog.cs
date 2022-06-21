using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ArchivoFisicoDocumentosLog
    {
        public decimal Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Operacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Afanterior { get; set; }
        public string? Afactual { get; set; }

        public virtual ArchivoFisico? AfactualNavigation { get; set; }
        public virtual ArchivoFisico? AfanteriorNavigation { get; set; }
    }
}
