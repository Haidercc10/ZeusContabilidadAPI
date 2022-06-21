using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConfiguracionEmailCobro
    {
        public decimal Iden { get; set; }
        public string? Usuario { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Plantilla { get; set; }
        public string? FechaPromesa { get; set; }
        public int? IndCliente { get; set; }
        public string? ClienteIni { get; set; }
        public string? ClienteFin { get; set; }
        public int? IndTercero { get; set; }
        public string? TerceroIni { get; set; }
        public string? TerceroFin { get; set; }
        public int? IndTipoCliente { get; set; }
        public string? TipoClienteIni { get; set; }
        public string? TipoClienteFin { get; set; }
        public int? IndSegmento { get; set; }
        public string? SegmentoIni { get; set; }
        public string? SegmentoFin { get; set; }
        public int? IndGrEmpresarial { get; set; }
        public string? GrEmpresarialIni { get; set; }
        public string? GrEmpresarialFin { get; set; }
        public int? IndVendedor { get; set; }
        public string? VendedorIni { get; set; }
        public string? VendedorFin { get; set; }
        public int? IndZona { get; set; }
        public string? ZonaIni { get; set; }
        public string? ZonaFin { get; set; }
        public int? IndMostrarDetalle { get; set; }
        public int? FechaBase { get; set; }
        public int? DiasAntela { get; set; }
        public int? Notificar { get; set; }
        public string? PersonalCobro { get; set; }
        public int? IndFechas { get; set; }
        public string? FechaF { get; set; }
        public int? IndConsecu { get; set; }
        public int? ConsecutivoI { get; set; }
        public int? ConsecutivoF { get; set; }
    }
}
