using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerEcuOcpEntidad
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenGerecuOcpEntidad { get; set; }
    }
}
