using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class JobEnvioEmailCobro
    {
        public decimal Iden { get; set; }
        public string? FechaPromesa { get; set; }
        public string? Cliente { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string? MensajeEnvio { get; set; }
        public string? Correo { get; set; }
        public decimal? IdenConfig { get; set; }
        public string? Configuracion { get; set; }
    }
}
