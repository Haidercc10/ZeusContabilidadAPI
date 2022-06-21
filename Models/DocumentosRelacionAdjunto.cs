using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DocumentosRelacionAdjunto
    {
        public int Id { get; set; }
        public byte IdEntidades { get; set; }
        public string KeyDocumento { get; set; } = null!;
        public int IdArchivosadjuntos { get; set; }

        public virtual ArchivosAdjunto IdArchivosadjuntosNavigation { get; set; } = null!;
        public virtual Entidade IdEntidadesNavigation { get; set; } = null!;
    }
}
