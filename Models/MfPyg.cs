using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPyg
    {
        public int IdPyg { get; set; }
        public int IdPadre { get; set; }
        public decimal Ventas { get; set; }
        public decimal Compras { get; set; }
        public decimal Arriendo { get; set; }
        public decimal Servicios { get; set; }
        public decimal Manoobra { get; set; }
        public decimal TotalCompgast { get; set; }
        public decimal Utilidad { get; set; }
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
