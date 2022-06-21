using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProyeccionHead
    {
        public int Iden { get; set; }
        public string Descripcion { get; set; } = null!;
        public string FechaProceso { get; set; } = null!;
        public string? Moneda { get; set; }
        public decimal? TasaCambio { get; set; }
    }
}
