using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConfiguracionEmailValera
    {
        public int Iden { get; set; }
        public string? Usuario { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Plantilla { get; set; }
        public int? IndCliente { get; set; }
        public string? ClienteIni { get; set; }
        public string? ClienteFin { get; set; }
        public int? IndTercero { get; set; }
        public string? TerceroIni { get; set; }
        public string? TerceroFin { get; set; }
        public int? IndPrefijoValera { get; set; }
        public string? PrefijoIni { get; set; }
        public string? PrefijoFin { get; set; }
        public string? FechaAnalisis { get; set; }
        public int? IndMostrarDetalle { get; set; }
        public int? VencimientoBase { get; set; }
        public int? DiasProxVence { get; set; }
        public int? Notificar { get; set; }
    }
}
