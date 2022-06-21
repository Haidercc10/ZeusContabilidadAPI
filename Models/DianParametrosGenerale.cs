using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DianParametrosGenerale
    {
        public string Ano { get; set; } = null!;
        public string Idvariable { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public int IdenDianparametrosgenerales { get; set; }
    }
}
