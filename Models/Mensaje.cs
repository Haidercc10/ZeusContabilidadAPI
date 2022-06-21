using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Mensaje
    {
        public decimal IdMensaje { get; set; }
        public decimal IdOrigen { get; set; }
        public string Asunto { get; set; } = null!;
        public DateTime FechaEnvio { get; set; }
        public string Mensaje1 { get; set; } = null!;
        public string? MensajeRtf { get; set; }
        public decimal IdDestino { get; set; }
        public bool Estado { get; set; }
        public bool Eliminado { get; set; }
    }
}
