using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SeccionesEfCabeceraOrdenado
    {
        public int Id { get; set; }
        public int? IdLibroLegal { get; set; }
        public string? Hijo { get; set; }
        public string? Padre { get; set; }
        public decimal? Nivel { get; set; }
        public string? Orden { get; set; }
    }
}
