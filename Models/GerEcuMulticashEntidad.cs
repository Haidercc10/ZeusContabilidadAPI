using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerEcuMulticashEntidad
    {
        public string Codigo { get; set; } = null!;
        public string Banco { get; set; } = null!;
        public int IdenGerecuMulticashEntidad { get; set; }
    }
}
