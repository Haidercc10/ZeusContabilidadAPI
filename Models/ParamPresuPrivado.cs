using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ParamPresuPrivado
    {
        public decimal IdParamPresuPrivado { get; set; }
        public decimal IdParam { get; set; }
        public string CodPresu { get; set; } = null!;
        public string Tipo { get; set; } = null!;
    }
}
