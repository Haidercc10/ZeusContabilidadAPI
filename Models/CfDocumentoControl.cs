using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfDocumentoControl
    {
        public decimal Id { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Ncf { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? AreaImpresion { get; set; }
        public string? PuntoEmision { get; set; }
        public string? TipoComprobante { get; set; }
    }
}
