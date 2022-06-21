using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Etiquetum
    {
        public int IdTipoEtiqueta { get; set; }
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Deshabilitado { get; set; }

        public virtual TipoEtiquetum IdTipoEtiquetaNavigation { get; set; } = null!;
    }
}
