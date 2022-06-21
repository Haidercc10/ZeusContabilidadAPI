using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ArchivosAdjunto
    {
        public ArchivosAdjunto()
        {
            DocumentosRelacionAdjuntos = new HashSet<DocumentosRelacionAdjunto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public byte[]? Archivo { get; set; }
        public decimal? IdenSesion { get; set; }
        public string? FormIdUnique { get; set; }
        public string? Usuario { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public int IdTipoArchivo { get; set; }
        public string? ArchivoBase64 { get; set; }
        public string? HefestoPathFile { get; set; }
        public string? HefestoPathFileVirtual { get; set; }

        public virtual ICollection<DocumentosRelacionAdjunto> DocumentosRelacionAdjuntos { get; set; }
    }
}
