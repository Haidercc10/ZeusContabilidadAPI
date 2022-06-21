using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContabilidadExterna
    {
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public DateTime FechaGeneracion { get; set; }
        public string Usuario { get; set; } = null!;
        public string XmlHead { get; set; } = null!;
        public string XmlBody { get; set; } = null!;
        public string? AplicacionExterna { get; set; }
        public string? DocumentoExterno { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string? Error { get; set; }
        public int IdenContabilidadexterna { get; set; }
        public string? Fechadocumento { get; set; }
    }
}
