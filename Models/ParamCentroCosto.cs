using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ParamCentroCosto
    {
        public decimal IdParamCentroCosto { get; set; }
        public decimal IdParam { get; set; }
        public string Idcenco { get; set; } = null!;
        public string Tipo { get; set; } = null!;
    }
}
