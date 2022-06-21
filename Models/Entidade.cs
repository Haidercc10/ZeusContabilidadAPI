using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Entidade
    {
        public Entidade()
        {
            DocumentosRelacionAdjuntos = new HashSet<DocumentosRelacionAdjunto>();
        }

        public byte Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenEntidades { get; set; }

        public virtual ICollection<DocumentosRelacionAdjunto> DocumentosRelacionAdjuntos { get; set; }
    }
}
