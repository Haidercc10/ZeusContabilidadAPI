using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmFuente
    {
        public string Fuente { get; set; } = null!;
        public string DescripcionFuente { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string? ReporteContable { get; set; }
        public string? FormatoImpresion { get; set; }
        public string? ReporteProfesional { get; set; }
        public string CreacionDeComprobantes { get; set; } = null!;
        public string ReutilizacionDeComprobantes { get; set; } = null!;
        public string ReversionDeComprobantes { get; set; } = null!;
        public string AperturaDeComprobantes { get; set; } = null!;
        public string CierreDeComprobantes { get; set; } = null!;
        public string? Autorizacion { get; set; }
        public string? RequiereCierreDocumento { get; set; }
        public string ModuloExterno { get; set; } = null!;
        public string Deshabilitado { get; set; } = null!;
        public string GeneraDiferido { get; set; } = null!;
        public string ManejaFacturaEnLinea { get; set; } = null!;
        public string ManejaFacturaDeContingencia { get; set; } = null!;
        public string AsociarImpuestosCartera { get; set; } = null!;
    }
}
