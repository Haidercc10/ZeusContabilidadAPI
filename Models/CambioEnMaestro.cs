using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CambioEnMaestro
    {
        public int Id { get; set; }
        public string Maestro { get; set; } = null!;
        public string Campo { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? ValorAnterior { get; set; }
        public string? ValorActual { get; set; }
    }
}
