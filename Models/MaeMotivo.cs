using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeMotivo
    {
        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string NombreMotivo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool? Deshabilitado { get; set; }
    }
}
