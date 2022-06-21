using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class BienesServicio
    {
        public BienesServicio()
        {
            BienesServiciosValors = new HashSet<BienesServiciosValor>();
        }

        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal PorcImporte { get; set; }
        public bool Deshabilitado { get; set; }
        public string? FechaIni { get; set; }
        public string? FechaFin { get; set; }
        public decimal Iden { get; set; }
        public int TipoCalculo { get; set; }
        public decimal Importe { get; set; }
        public int BaseCalculo { get; set; }

        public virtual ICollection<BienesServiciosValor> BienesServiciosValors { get; set; }
    }
}
