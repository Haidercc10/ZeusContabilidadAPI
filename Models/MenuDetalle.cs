using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MenuDetalle
    {
        public int IdMenu { get; set; }
        public string TipoMenu { get; set; } = null!;
        public int Pariente { get; set; }
        public bool Separador { get; set; }
        public int Orden { get; set; }
        public string? Nombre { get; set; }
        public string Shortcut { get; set; } = null!;
        public int IdenMenudetalle { get; set; }

        public virtual Menu IdMenuNavigation { get; set; } = null!;
    }
}
