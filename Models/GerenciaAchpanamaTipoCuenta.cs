using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaAchpanamaTipoCuenta
    {
        public string CodTipoCuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string CodGerencia { get; set; } = null!;
        public int IdenGerenciaAchpanamaTipocuentas { get; set; }
    }
}
