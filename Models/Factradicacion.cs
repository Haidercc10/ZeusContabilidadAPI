using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factradicacion
    {
        public decimal Iden { get; set; }
        public string FechaRadicacion { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string FechaFact { get; set; } = null!;
        public string? Observacion { get; set; }
        public string Usuario { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public DateTime FechaGrabacion { get; set; }
    }
}
