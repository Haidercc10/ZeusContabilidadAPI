using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfComprobanteRetencion
    {
        public int Iden { get; set; }
        public string ComprobanteRetencion { get; set; } = null!;
        public int IdenAutorizacionCi { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string FuenteNew { get; set; } = null!;
        public string DocumentoNew { get; set; } = null!;
    }
}
