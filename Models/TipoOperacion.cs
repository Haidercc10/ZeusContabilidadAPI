using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoOperacion
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Deshabilitado { get; set; }
        public int IdenTipooperacion { get; set; }
    }
}
