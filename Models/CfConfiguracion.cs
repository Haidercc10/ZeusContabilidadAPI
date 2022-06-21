using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfConfiguracion
    {
        public decimal Id { get; set; }
        public int Tipo { get; set; }
        public string Codigo1 { get; set; } = null!;
        public string Codigo2 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string PuntoDeEmision { get; set; } = null!;
        public string AreaDeImpresion { get; set; } = null!;
        public string TipoDeComprobante { get; set; } = null!;
    }
}
