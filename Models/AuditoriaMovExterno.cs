using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AuditoriaMovExterno
    {
        public decimal Iden { get; set; }
        public string Fecha { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public DateTime FechaProceso { get; set; }
        public int IdAplicacion { get; set; }
        public int Estado { get; set; }
        public string MensajeError { get; set; } = null!;
    }
}
