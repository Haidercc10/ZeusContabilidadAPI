using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UnidadImpTributarium
    {
        public int Iden { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? FechaIni { get; set; }
        public string? FechaFin { get; set; }
        public decimal ValorUit { get; set; }
        public decimal CantidadUit { get; set; }
        public decimal ToleranciaUit { get; set; }
        public int Deshabilitado { get; set; }
    }
}
