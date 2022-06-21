using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasImpresion
    {
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public bool? Original { get; set; }
        public int NroCopiasImpresas { get; set; }
        public bool ImpresionAdicional { get; set; }
        public int IdenFacturasImpresion { get; set; }
    }
}
