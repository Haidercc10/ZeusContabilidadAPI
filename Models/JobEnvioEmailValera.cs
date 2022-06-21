using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class JobEnvioEmailValera
    {
        public decimal Iden { get; set; }
        public string? Fecha { get; set; }
        public string? FechaAnalisis { get; set; }
        public string? Configuracion { get; set; }
        public string? Plantilla { get; set; }
        public string? Cliente { get; set; }
        public int? IndBaseEn { get; set; }
        public string? FechaBaseEn { get; set; }
        public int? DiasProxVence { get; set; }
        public int? Notificar { get; set; }
        public int? Enviado { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string? MensajeEnvio { get; set; }
    }
}
