using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfProyinversion
    {
        public int IdProyinv { get; set; }
        public int IdPadre { get; set; }
        public string Producto { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Valorunitario { get; set; }
        public decimal Valortotal { get; set; }
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
