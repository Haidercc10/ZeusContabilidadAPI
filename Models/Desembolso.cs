using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Desembolso
    {
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string? Operacion { get; set; }
        public string? Identificacion { get; set; }
        public string? Nombre { get; set; }
        public int IdenDesembolsos { get; set; }
    }
}
