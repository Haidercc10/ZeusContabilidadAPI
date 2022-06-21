using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfDeuda
    {
        public int Iddeudas { get; set; }
        public int IdPadre { get; set; }
        public string Deudas { get; set; } = null!;
        public decimal Cuantia { get; set; }
        public string Debea { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
