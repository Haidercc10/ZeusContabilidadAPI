using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TasasMercado
    {
        public decimal Iden { get; set; }
        public string Fecha { get; set; } = null!;
        public string FechaFinal { get; set; } = null!;
        public double TasaMercado { get; set; }
        public int Deshabilitado { get; set; }
    }
}
