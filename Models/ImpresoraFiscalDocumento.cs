using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpresoraFiscalDocumento
    {
        public decimal Iden { get; set; }
        public decimal? TipoDocumento { get; set; }
        public decimal? Consecutivo { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? NoFiscalImpresora { get; set; }
        public string? NoSerialImpresora { get; set; }
    }
}
