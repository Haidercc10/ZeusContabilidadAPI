using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Menu
    {
        public Menu()
        {
            MenuDetalles = new HashSet<MenuDetalle>();
        }

        public int IdMenu { get; set; }
        public string Nombre { get; set; } = null!;
        public int Relacion { get; set; }
        public int Pariente { get; set; }
        public int? Orden { get; set; }
        public decimal? IdForma { get; set; }
        public bool Fixed { get; set; }
        public int IdenMenu { get; set; }

        public virtual ICollection<MenuDetalle> MenuDetalles { get; set; }
    }
}
