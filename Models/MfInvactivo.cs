using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfInvactivo
    {
        public int IdInvactivos { get; set; }
        public int IdPadre { get; set; }
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Condicion { get; set; } = null!;
        public decimal Valor { get; set; }
        public decimal Valoradeudado { get; set; }
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
