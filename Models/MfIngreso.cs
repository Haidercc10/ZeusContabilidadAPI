using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfIngreso
    {
        public int IdIngresos { get; set; }
        public int IdPadre { get; set; }
        public string Entrada { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Empresa { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
