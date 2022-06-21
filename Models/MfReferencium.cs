using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfReferencium
    {
        public int IdReferencia { get; set; }
        public int IdPadre { get; set; }
        public string Codreferencia { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
