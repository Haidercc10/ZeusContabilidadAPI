using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaAchpanamaBanco
    {
        public string CodBanco { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public int IdenGerenciaAchpanamaBancos { get; set; }

        public virtual Banco CodBancoNavigation { get; set; } = null!;
    }
}
