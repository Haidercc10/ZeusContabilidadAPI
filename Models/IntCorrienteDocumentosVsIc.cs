using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class IntCorrienteDocumentosVsIc
    {
        public int Iden { get; set; }
        public string FuenteDocRelacionado { get; set; } = null!;
        public string NumeroDocRelacionado { get; set; } = null!;
        public string FechaDocRelacionado { get; set; } = null!;
        public string FuenteIc { get; set; } = null!;
        public string DocumentoIc { get; set; } = null!;
        public string FechaIc { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public int Automatica { get; set; }
        public string TipoDocumentoOrigen { get; set; } = null!;
    }
}
