using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscRefgeneral
    {
        public int IdRefgenerales { get; set; }
        public int IdescPadre { get; set; }
        public string Codreferencia { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Barrio { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Telefono { get; set; } = null!;

        public virtual MfEscTablapadre IdescPadreNavigation { get; set; } = null!;
    }
}
