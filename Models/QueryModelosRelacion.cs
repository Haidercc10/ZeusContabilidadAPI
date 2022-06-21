using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryModelosRelacion
    {
        public string QueryEspecial { get; set; } = null!;
        public string Parametro { get; set; } = null!;
        public string QuerySecuencia { get; set; } = null!;
        public string Columna { get; set; } = null!;
        public int Seleccionado { get; set; }
        public int IdenQuerymodelosrelacion { get; set; }
    }
}
