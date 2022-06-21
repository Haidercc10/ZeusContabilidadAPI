using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EtiquetaAtributo
    {
        public int IdEtiqueta { get; set; }
        public string Atributo { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? Cuenta { get; set; }
        public int IdenEtiquetaAtributos { get; set; }

        public virtual Etiquetum IdEtiquetaNavigation { get; set; } = null!;
    }
}
