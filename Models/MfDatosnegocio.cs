using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfDatosnegocio
    {
        public int IdDatosneg { get; set; }
        public int IdPadre { get; set; }
        public string Expoficio { get; set; } = null!;
        public string Tiemponeg { get; set; } = null!;
        public string Microprod { get; set; } = null!;
        public string Microneg { get; set; } = null!;
        public string Llevacta { get; set; } = null!;
        public string Ahorra { get; set; } = null!;
        public string Puesto { get; set; } = null!;
        public string Surte { get; set; } = null!;
        public string Ppalpuntos { get; set; } = null!;
        public decimal Nempleados { get; set; }
        public string TipoEstudio { get; set; } = null!;
        public decimal Nempleos { get; set; }
        public decimal Npersonas { get; set; }

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
