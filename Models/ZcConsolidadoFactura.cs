using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZcConsolidadoFactura
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Agrupamiento { get; set; } = null!;
        public byte Habilitar { get; set; }
    }
}
