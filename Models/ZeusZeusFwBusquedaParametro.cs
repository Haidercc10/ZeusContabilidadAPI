using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusZeusFwBusquedaParametro
    {
        public string DsBusqueda { get; set; } = null!;
        public string DsParametro { get; set; } = null!;
        public string? DsNombre { get; set; }
        public string? DsTipo { get; set; }
        public int? InOrden { get; set; }
    }
}
