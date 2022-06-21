using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesMenu
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; } = null!;
        public int Relacion { get; set; }
        public int Pariente { get; set; }
        public int? Orden { get; set; }
        public decimal? IdForma { get; set; }
        public int IdenRolesMenu { get; set; }
    }
}
