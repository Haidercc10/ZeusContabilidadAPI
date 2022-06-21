using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeventosI
    {
        public string TipoEvento { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Aplicacion { get; set; }
        public bool Deshabilitar { get; set; }
        public int IdenMaeventosi { get; set; }

        public virtual MaeTipodeEvento TipoEventoNavigation { get; set; } = null!;
    }
}
