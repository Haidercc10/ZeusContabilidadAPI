using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfCaptrabajo
    {
        public int IdCaptrabajo { get; set; }
        public int IdPadre { get; set; }
        public decimal Propio { get; set; }
        public decimal Proveedores { get; set; }
        public decimal Prestado { get; set; }
        public decimal Otros { get; set; }
        public decimal TotalCapital { get; set; }
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
