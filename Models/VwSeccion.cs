using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VwSeccion
    {
        public int Iden { get; set; }
        public string Tipo { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string CodigoPadre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public string? Orden { get; set; }
    }
}
