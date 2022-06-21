using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VwBienesServicio
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal PorcImporte { get; set; }
        public bool Deshabilitado { get; set; }
        public string FechaIni { get; set; } = null!;
        public string FechaFin { get; set; } = null!;
        public decimal Iden { get; set; }
    }
}
