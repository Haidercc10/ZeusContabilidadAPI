using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SeccionesEfOrdenImpresion
    {
        public int Id { get; set; }
        public int? IdLibroLegal { get; set; }
        public string? Codigo { get; set; }
        public int? Orden { get; set; }
    }
}
