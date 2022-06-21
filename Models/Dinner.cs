using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Dinner
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string? Detalle { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public short? Estado { get; set; }
        public string? FormatoArchivoPlano { get; set; }
    }
}
