using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaConavi
    {
        public string Codinstalacion { get; set; } = null!;
        public string Codempresa { get; set; } = null!;
        public string Idbanco { get; set; } = null!;
        public string Entidad { get; set; } = null!;
        public string Regional { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Tipocta { get; set; } = null!;
        public int IdenGerenciaConavi { get; set; }
    }
}
