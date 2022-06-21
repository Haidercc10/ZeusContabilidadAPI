using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SeccionesOrdenado
    {
        public string? Hijo { get; set; }
        public string? Padre { get; set; }
        public decimal? Nivel { get; set; }
        public string? Orden { get; set; }
        public string? Tipo { get; set; }
        public int Id { get; set; }
    }
}
