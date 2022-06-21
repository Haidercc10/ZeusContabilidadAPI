using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasAuditoriaImpresion
    {
        public int Id { get; set; }
        public bool Original { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
    }
}
