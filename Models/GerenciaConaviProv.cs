using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaConaviProv
    {
        public string Idprove { get; set; } = null!;
        public string? Idbanco { get; set; }
        public string? Entidad { get; set; }
        public string? Regional { get; set; }
        public string? Oficina { get; set; }
        public string? Cuenta { get; set; }
        public string? Tipocuenta { get; set; }
        public int IdenGerenciaConaviProv { get; set; }
    }
}
