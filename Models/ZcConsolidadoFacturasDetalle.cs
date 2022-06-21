using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZcConsolidadoFacturasDetalle
    {
        public int Id { get; set; }
        public int IdZcConsolidadoFacturas { get; set; }
        public int IdAplicativo { get; set; }
        public string? Servidor { get; set; }
        public string? Base { get; set; }
        public string? Fuentes { get; set; }
        public string? Conceptos { get; set; }
        public string? Ambientes { get; set; }
        public string? TipoDocumento { get; set; }
    }
}
