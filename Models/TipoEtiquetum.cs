using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoEtiquetum
    {
        public TipoEtiquetum()
        {
            Etiqueta = new HashSet<Etiquetum>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Deshabilitado { get; set; }

        public virtual ICollection<Etiquetum> Etiqueta { get; set; }
    }
}
